using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Security.Claims;
using System.Text;

namespace Planify.Services
{

    //DI Config and DB connection
    public static partial class BuilderConfigurationService
    {
        public static void SetScopes(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IGenericCRUDRepository<Department, int>, DepartmentRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<Role, int>, RoleRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<Employee, int>, EmployeeRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<Person, int>, PersonRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<User, int>, UserRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<Project, int>, ProjectRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<ProjectTask, int>, ProjectTaskRepository>();
            builder.Services.AddScoped<IGenericCRUDRepository<ProjectTaskComentary, int>, ProjectTaskComentaryRepository>();

            //Unit of work:
            builder.Services.AddScoped<IUserManagementUoW, UserManagementUoW>();
            builder.Services.AddScoped<IProjectManagement_UoW, ProjectManagement_UoW>();
        }


        public static void AddSqlServer(WebApplicationBuilder builder)
        {
            var SqlConnection = builder.Configuration.GetConnectionString("SqlServerCon");
            builder.Services.AddDbContext<ProjectContext>(option => option.UseSqlServer(SqlConnection));
        }

    }

    //Authentication Scheme Config
    public static partial class BuilderConfigurationService
    {
        public static void SetAuthenticationScheme(WebApplicationBuilder builder)
        {
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = builder.Configuration["JWT:Issuer"],
                        ValidAudience = builder.Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                                Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]!)
                        ),

                        ClockSkew = TimeSpan.Zero,
                        NameClaimType = "UserId",
                        RoleClaimType = ClaimTypes.Role,
                    }
                );
        }


    }


    //Policies
    public static partial class BuilderConfigurationService
    {
        public static void SetAuthorizationPolicies(WebApplicationBuilder builder)
        {
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy(PolicyNames.SA, PoliciesService.GetSA());
                options.AddPolicy(PolicyNames.Admin, PoliciesService.GetAdmin());
                options.AddPolicy(PolicyNames.Manager, PoliciesService.GetPjManager());
                options.AddPolicy(PolicyNames.RhAdmin, PoliciesService.GetRhAdmin());
                options.AddPolicy(PolicyNames.Rh, PoliciesService.GetHumanResources());
                options.AddPolicy(PolicyNames.Viewer, PoliciesService.GetViewer());

                //Combinaciones
                options.AddPolicy(PolicyNames.MinimumAdmin, PoliciesService.GetSAorAdmin());
                options.AddPolicy(PolicyNames.MinimumRhAdmin, PoliciesService.GetRhAdmin_Admin_SA());
                options.AddPolicy(PolicyNames.MinimumRh, PoliciesService.Get_Rh_RhAdmin_Admin_SA());
            });
        }

    }

    //Swagger config
    public static partial class BuilderConfigurationService
    {
        public static void SetSwaggerGen(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Planify", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
            });

        }

        public static void SetSwaggerConfig(WebApplication? app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.DocExpansion(DocExpansion.None); // Colapsa los endpoints
            });
        }
    }


}
