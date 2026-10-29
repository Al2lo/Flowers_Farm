using Application.FlowersFarm.Extensions;
using Domain.FlowersFarm.Extensions;
using Infrastructure.FlowersFarm.Extensions;
using WebApi.FlowersFarm.BotModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services
    .AddDomain()
    .AddInfrastructure()
    .AddApplication();

builder.Services.AddSingleton<TgBot>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
