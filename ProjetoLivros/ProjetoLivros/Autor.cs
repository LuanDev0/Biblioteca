using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Autor
    {
        public Autor(string nome)
        {
            Nome = nome;
        }

        List<Box> Box = new List<Box>();

        public string Nome { get;}


        public void AddBox(Box box)
        {
            Box.Add(box);
        }

        public void Bibliografia()
        {
            Console.WriteLine($"Livros do Autor {Nome}: \n");

            foreach (Box box in Box)
            {
                box.ExibirLivrosBox();
            }

        }
    }
}
