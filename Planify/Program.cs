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
BuilderConfigurationService.SetAuthentication(builder);

BuilderConfigurationService.AddSqlServer(builder);

var app = builder.Build();
app.UseAuthentication();
app.UseAuthentication();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    BuilderConfigurationService.SetSwagger(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
