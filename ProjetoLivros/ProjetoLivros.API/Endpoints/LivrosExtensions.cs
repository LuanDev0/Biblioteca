using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.API.Requests;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;

namespace ProjetoLivros.API.Endpoints
{
    public static class LivrosExtensions
    {

        public static void AddEndPointsLivros(this WebApplication app)
        {
            app.MapGet("/Livros", ([FromServices] DAL<Livro> DAL) =>
            {
                var livro = DAL.ListaRecuperarPor(l => l.Titulo == "Melações melosas");

                if(livro == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(livro);
                }

            });

            app.MapPost("/Livros", ([FromServices] DAL<Livro> DAL, [FromBody] LivroRequest livroRequest) =>
            {
                var livro = new Livro(livroRequest.titulo, livroRequest.paginas, livroRequest.lido); 

                DAL.Adicionar(livro);
                return Results.Ok();
            })
            ;
               
        }

    }
}
