using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.API.Requests;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;
using ProjetoLivros.Shared.Models.Models;

namespace ProjetoLivros.API.Endpoints
{
    public static class GenerosExtensions
    {
        public static void AddEndPointsGeneros(this WebApplication app)
        {
            app.MapGet("/Genero", ([FromServices] DAL<Genero> DAL) =>
            {
                var genero = DAL.RecuperarPor(g => g.Nome != "");

                if (genero == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(genero);
                }
            });

            app.MapPost("/Genero", ([FromServices] DAL < Genero > DAL, [FromBody]GeneroRequest generoRequest) =>
            {
                var genero = new Genero(generoRequest.nome, generoRequest.descricao);
                DAL.Adicionar(genero);
                return Results.Ok();

            });

        }

    }
}
