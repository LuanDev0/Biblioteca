using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.API.Endpoints;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;
using ProjetoLivros.Shared.Models.Models;
using System.Data.SqlTypes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BibliotecaContext>();

builder.Services.AddTransient<DAL<Colecao>>();
builder.Services.AddTransient<DAL<Livro>>();
builder.Services.AddTransient<DAL<Genero>>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddEndpointsColecoes();
app.AddEndPointsLivros();
app.AddEndPointsGeneros();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
