using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Planify.Data;
using Planify.Models;
using Planify.Repositories;

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
            //Unit of work:
            builder.Services.AddScoped<IUOW_Users_Employee, UOW_Users>();
        }


        public static void AddSqlServer(WebApplicationBuilder builder)
        {
            var SqlConnection = builder.Configuration.GetConnectionString("SqlServerCon");
            builder.Services.AddDbContext<ProjectContext>(option => option.UseSqlServer(SqlConnection));
        }
    }
}
