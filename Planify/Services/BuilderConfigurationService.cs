﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
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
        public static void AddCors(WebApplicationBuilder builder)
        {
            builder.Services.AddCors(cors =>
            {
                cors.AddPolicy(name: "Cors_Angular",
                    builder => builder.WithOrigins(@"http://localhost:4200")
                        .AllowAnyHeader() // Permite cualquier encabezado
                        .AllowAnyMethod() // Permite cualquier método HTTP
                        .AllowCredentials() // Permite el envío de cookies o credenciales
                );
            });
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
                //TODO: No se si se debería eliminar las politicas individuales y falta la de Developer
                //options.AddPolicy(PolicyNames.Developer, PoliciesService.GetMinimumDeveloper());

                // [Combinated]
                options.AddPolicy(PolicyNames.MinimumAdmin, PoliciesService.GetMinimumAdmin());
                options.AddPolicy(PolicyNames.MinimumRhAdmin, PoliciesService.GetMinimumRhAdmin());
                options.AddPolicy(PolicyNames.MinimumRh, PoliciesService.GetMinimumRh());
                options.AddPolicy(PolicyNames.MinimumManager, PoliciesService.GetMinimumManager());
                options.AddPolicy(PolicyNames.MinimumDeveloper, PoliciesService.GetMinimumDeveloper());

                // [Combinated with Viewer]
                options.AddPolicy(PolicyNames.MinimumRhAdminOrViewer, PoliciesService.Get_MinimumRhAdmin_OrViewer());
                options.AddPolicy(PolicyNames.MinimumAdminOrViewer, PoliciesService.Get_MinimumAdmin_OrViewer());
                options.AddPolicy(PolicyNames.MinimumRhOrViewer, PoliciesService.Get_MinimumRh_OrViewer());
                options.AddPolicy(PolicyNames.MinimumManagerOrViewer, PoliciesService.Get_MinimumManager_OrViewer());
                options.AddPolicy(PolicyNames.MinimumDeveloperOrViewer, PoliciesService.Get_MinimumDeveloper_OrViewer());
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
