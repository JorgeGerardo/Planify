using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Planify.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c => { c.MapType<DateOnly>(() => new OpenApiSchema { Type = "string", Format = "date", Example = new OpenApiString("2023-12-31") }); });
builder.Services.AddSwaggerGen(c => { c.MapType<TimeOnly>(() => new OpenApiSchema { Type = "string", Format = "time", Example = new OpenApiString("23:59:10.999999999") }); });
builder.Services.AddSwaggerGen(c => { c.MapType<DateTime>(() => new OpenApiSchema { Type = "string", Format = "date", Example = new OpenApiString("2024-12-31 23:59:59.1999999") }); });


builder.Services.AddEndpointsApiExplorer();

//Swagger config
BuilderConfigurationService.SetSwaggerGen(builder);

//Scopes:
BuilderConfigurationService.SetScopes(builder);

//Auth
BuilderConfigurationService.SetAuthenticationScheme(builder);
BuilderConfigurationService.SetAuthorizationPolicies(builder);

BuilderConfigurationService.AddSqlServer(builder);
BuilderConfigurationService.AddCors(builder);

var app = builder.Build();
app.UseCors("Cors_Angular");
app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
    BuilderConfigurationService.SetSwaggerConfig(app);


app.UseHttpsRedirection();
app.MapControllers();
app.Run();
