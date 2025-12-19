using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Box
    {

        public Box(string nome)
        {
            Nome = nome;
        }

        //Variaveis
        private List<Livro> livros = new List<Livro>();

        //Propriedades
        public string Nome { get;}
        public int MaxPag => livros.Sum(l => l.Paginas);
        public int QuantidadeLivros => livros.Count;
        

        //Métodos
        public void AdicionaLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ExibirLivrosBox()
        {
           foreach(var livro in livros)
            {
                Console.WriteLine(livro.Titulo);
            }
        }

        public string QuantidadePaginas()
        {
            int maxPag = 0;

            foreach(var livro in livros)
            {
                maxPag += livro.Paginas;
            }

            return maxPag.ToString();
        }
    }
}