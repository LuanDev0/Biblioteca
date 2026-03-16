using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.API.Requests;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;
using ProjetoLivros.Shared.Models.Models;

namespace ProjetoLivros.API.Endpoints
{
    public static class LivrosExtensions
    {

        public static void AddEndPointsLivros(this WebApplication app)
        {
            app.MapGet("/Livros", ([FromServices] DAL<Livro> DAL) =>
            {
                var livro = DAL.ListaRecuperarPor(l => l.Titulo != "");

                if(livro == null)
                {
                    return Results.NotFound();
                }
                else
                {
                    return Results.Ok(livro);
                }

            });

            app.MapPost("/Livros", ([FromServices] DAL<Livro> DAL, [FromServices] DAL<Genero> DALGenero, [FromBody] LivroRequest livroRequest) =>
            {
                var livro = new Livro(livroRequest.titulo, livroRequest.paginas, livroRequest.lido)
                {
                    Generos = livroRequest.Generos is not null? GeneroRequestConverter(livroRequest.Generos, DALGenero): new List<Genero>()
                };
                
                DAL.Adicionar(livro);
                return Results.Ok();
            })
            ;
               
        }

        private static ICollection<Genero> GeneroRequestConverter(ICollection<GeneroRequest> generos, DAL<Genero> dalGenero)
        {
            var listaDeGeneros = new List<Genero>();
            foreach (var item in generos)
            {
                var entity = RequestToEntity(item);
                var genero = dalGenero.RecuperarPor(g => g.Nome.ToUpper().Equals(item.nome.ToUpper()));
                if (genero is not null)
                {
                    listaDeGeneros.Add(genero);
                }
                else
                {
                    listaDeGeneros.Add(entity);
                }
            }
                return listaDeGeneros;
        }

        private static Genero RequestToEntity(GeneroRequest genero)
        {
            return new Genero() { Nome = genero.nome, Descricao = genero.descricao };
        }


    }

}
