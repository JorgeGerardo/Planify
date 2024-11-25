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
        }


        public static void AddSqlServer(WebApplicationBuilder builder)
        {
            var SqlConnection = builder.Configuration.GetConnectionString("SqlServerCon");
            builder.Services.AddDbContext<ProjectContext>(option => option.UseSqlServer(SqlConnection));
        }
    }
}
