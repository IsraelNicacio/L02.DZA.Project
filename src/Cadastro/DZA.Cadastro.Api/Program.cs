using DZA.Cadastro.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiConfiguration();
builder.Services.RegisterServices();
builder.Services.RegisterTenant(builder.Configuration);

var app = builder.Build();
app.UseSwaggerConfiguratio();
app.UseApiConfiguration(app.Environment);
app.Run();
