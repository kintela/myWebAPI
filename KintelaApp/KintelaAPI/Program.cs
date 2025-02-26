using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using KintelaAPI.EndPoints;
using KintelaData;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var keyVaultName = builder.Configuration.GetValue<string>("KEY_VAULT_NAME");
var kvUri = $"https://{keyVaultName}.vault.azure.net";
var secretNameEncuestasSAP = builder.Configuration.GetValue<string>("SECRET_NAME");

var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());

KeyVaultSecret secretEncuestasSAP = client.GetSecret(secretNameEncuestasSAP);

string connectionString = secretEncuestasSAP.Value;


builder.Services.AddDbContext<KintelaContext>(
	opt =>opt
	//.UseSqlServer(builder.Configuration.GetConnectionString("KintelaDatabaseAzure"))
	.UseSqlServer(connectionString)
	.EnableSensitiveDataLogging()
	.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
);

builder.Services.ConfigureHttpJsonOptions(options =>
{
	options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
	options.SerializerOptions.PropertyNameCaseInsensitive = true;
});

builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAngularLocalhost",
			builder =>
			{
				builder.WithOrigins("http://localhost:4200")
								 .AllowAnyHeader()
								 .AllowAnyMethod();
			});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();

app.UseCors("AllowAngularLocalhost");

//app.UseAntiforgery();

app.MapGrupoEndpoints();
app.MapRecetasEndpoints();
app.MapMenuSemanalEndpoints();
app.MapCategoriaEndpoints();

app.Run();
