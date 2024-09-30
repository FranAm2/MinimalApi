
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MinimalApi.DTOs;
using MinimalApi.Infraestrutura.Db;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(
    options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
);

var app = builder.Build();

app.MapGet("/", () => "Opa!");

app.MapPost("/login", (LoginDTO loginDTO) =>
{
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
    {
        return Results.Ok("Login com sucesso!");
    }
    else
    {
        return Results.Unauthorized();
    }
});

app.Run();
