using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Leitor
    {
        public Leitor(String nome, int idade)
        {

            Nome = nome;

            Idade = idade;
        }

        public int Id { get; }
        public string Nome { get;  }
        public int Idade { get; }


    }
}
