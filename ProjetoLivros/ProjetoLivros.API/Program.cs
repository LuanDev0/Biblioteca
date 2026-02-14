using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.API.Endpoints;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;
using System.Data.SqlTypes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BibliotecaContext>();

builder.Services.AddTransient<DAL<Colecao>>();
builder.Services.AddTransient<DAL<Livro>>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddEndpointsColecoes();
app.AddEndPointsLivros();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
