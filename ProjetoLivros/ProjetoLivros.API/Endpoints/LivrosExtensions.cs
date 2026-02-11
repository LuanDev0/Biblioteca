using Microsoft.AspNetCore.Mvc;
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

            }

            );
               
        }

    }
}
