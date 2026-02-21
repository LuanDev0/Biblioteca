using ProjetoLivros.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros.Shared.Models.Models
{
    public class Genero
    {
        public Genero(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public Genero() {}

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public virtual ICollection<Livro> Livro { get; set; }

        public override string ToString()
        {
            return $"Nome do Gênero: {Nome}";
        }
    }
}
