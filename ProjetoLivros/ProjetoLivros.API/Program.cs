using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;
using System.Data.SqlTypes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BibliotecaContext>();
builder.Services.AddTransient<DAL<Colecao>>();

var app = builder.Build();

app.MapGet("/Colecoes", ([FromServices] DAL<Colecao> DAL) =>
{
    var colecao = DAL.ListaRecuperarPor(c => c.Id > 0);

    if(colecao == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(colecao);
    }

});

app.MapGet("/Colecoes/{Nome}", ([FromServices] DAL < Colecao > DAL, string Nome) =>
{
    var colecao = DAL.RecuperarPor(c => c.Nome.ToUpper().Equals(Nome.ToUpper()) );

    if (colecao == null)
    {
        return Results.NotFound();
    }
    else
    {
        return Results.Ok(colecao);
    }
});

app.MapPost("/Colecoes", ([FromServices] DAL < Colecao > DAL, [FromBody]Colecao colecao) =>
{
    DAL.Adicionar(colecao);
    return Results.Ok();
});

app.Run();
