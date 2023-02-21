using Azure.Identity;
using HackerRank.Monitoring.Api.Authentication;
using HackerRank.Monitoring.Api.Extensions;
using HackerRank.Monitoring.Infrastructrure.Configuration;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


var globalServicesCollection = builder.Services;
globalServicesCollection.AddControllers();
globalServicesCollection.AddHttpContextAccessor();
globalServicesCollection.AddHRMonitaringRepositories(builder.Configuration);

globalServicesCollection.AddEndpointsApiExplorer();
globalServicesCollection.ConfigureAuthentication(builder.Configuration);
globalServicesCollection.AddSwagger();

var keyvaultendpoint = new Uri($"https://{builder.Configuration["keyvaultname"]}.vault.azure.net/");
builder.Configuration.AddAzureKeyVault(keyvaultendpoint, new DefaultAzureCredential());
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();

if (true)
{
    app.EnableSwagger();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseCors();

app.EnableAuthentication();

app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
