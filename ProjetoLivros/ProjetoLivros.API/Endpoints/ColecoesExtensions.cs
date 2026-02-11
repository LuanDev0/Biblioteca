using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;

namespace ProjetoLivros.API.Endpoints
{
    public static class ColecoesExtensions
    {

        public static void AddEndpointsColecoes(this WebApplication app)
        {
            app.MapGet("/Colecoes", ([FromServices] DAL<Colecao> DAL) =>
            {
                var colecao = DAL.ListaRecuperarPor(c => c.Id > 0);

                if (colecao == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(colecao);
                }

            });

            app.MapGet("/Colecoes/{Nome}", ([FromServices] DAL<Colecao> DAL, string Nome) =>
            {
                var colecao = DAL.RecuperarPor(c => c.Nome.ToUpper().Equals(Nome.ToUpper()));

                if (colecao == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(colecao);
                }
            });

            app.MapPost("/Colecoes", ([FromServices] DAL<Colecao> DAL, [FromBody] Colecao colecao) =>
            {
                DAL.Adicionar(colecao);
                return Results.Ok();
            });

            app.MapDelete("/Colecoes/{id}", ([FromServices] DAL<Colecao> DAL, int id) =>
            {
                var colecao = DAL.RecuperarPor(c => c.Id == id);

                if (colecao == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    DAL.Remover(colecao);
                    return Results.NoContent();
                }
            });

            app.MapPut("/Colecoes/", ([FromServices] DAL<Colecao> DAL, [FromBody] Colecao colecao) =>
            {

                var colecaoAtualiza = DAL.RecuperarPor(c => c.Id == colecao.Id);

                if (colecaoAtualiza == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    colecaoAtualiza.Nome = colecao.Nome;
                    colecaoAtualiza.Id = colecao.Id;
                    DAL.Atualizar(colecaoAtualiza);
                    return Results.Ok();
                }

            });
        }

    }
}
