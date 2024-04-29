using Serilog;
using System.Reflection;
using DemoLibrary.Infrastructure;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);
string outputTem = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz } {RequestId,13} [{Level:u3}] {Message:lj} {Properties} {NewLine}{Exception}";


ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;


Log.Logger = new LoggerConfiguration()
                 .Enrich.FromLogContext()
                 .WriteTo.Console(outputTemplate: outputTem)
                 .ReadFrom.Configuration(configuration)
                 .CreateBootstrapLogger();



configuration.AddJsonFile($"appsettings.{environment.EnvironmentName}.json", optional: false, reloadOnChange: true);


// Add services to the container.
builder.Services.AddControllers();


builder.Services.AddMemoryCache();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMemoryCache();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddInfrastructure(configuration, environment.IsEnvironment("Local"));
builder.Services.AddInfrastructureExternalServices(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
