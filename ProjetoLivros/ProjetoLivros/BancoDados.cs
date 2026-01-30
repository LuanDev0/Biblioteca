using ProjetoLivros.Modelos;
using System.Net.Http.Headers;

namespace ProjetoLivros
{
    public class BancoDados
    {
        private List<Livro> livros = new List<Livro>()
        {
            new LivroFisico("1984", new Autor("George Orwell"), 328, true, 29.90),
            new LivroDigital("O Senhor dos Anéis", new Autor("J.R.R. Tolkien"), 1178, 499)
        };

        internal Livro BuscarLivroPeloTitulo(string titulo)
        {
            foreach(var l in livros)
            {
                if (l.Titulo.Equals(titulo))
                {
                    return l;
                }
            }               
            return null;
        }

    }
}
