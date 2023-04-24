using Exercicio_Semana9.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver.Core.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = "Server=LUCIANONOTE\\SQLEXPRESS;database=Semana;Trusted_Connection=True;TrustServerCertificate=True;";

builder.Services.AddDbContext<SemanaContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddDbContext<SemanaContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
