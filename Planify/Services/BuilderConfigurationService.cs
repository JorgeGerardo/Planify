using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;
using Planify.Repositories.UoW;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Planify.Services
{
    public static class BuilderConfigurationService
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

        public static void SetSwagger(WebApplication? app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.DocExpansion(DocExpansion.None); // Colapsa los endpoints
            });
        }
    }
}
