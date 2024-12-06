using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Planify.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

//Swagger config
BuilderConfigurationService.SetSwaggerGen(builder);

//Scopes:
BuilderConfigurationService.SetScopes(builder);

//Auth
BuilderConfigurationService.SetAuthenticationScheme(builder);

BuilderConfigurationService.AddSqlServer(builder);

var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    BuilderConfigurationService.SetSwaggerConfig(app);


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
