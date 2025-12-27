namespace ProjetoLivros
{
    internal class Leitor : IGeneroPreferido
    {
        //Construtor
        public Leitor(String nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        //Propriedades
        public int Id { get; }
        public string Nome { get;  }
        public int Idade { get; }
        public Avaliacao Avaliacao { get; private set; }

        public string GeneroPreferido { get; private set; }

        //Métodos
        public void MudarGenero(string novoGenero)
        {
            GeneroPreferido = novoGenero;
        }

        public void Avaliar(int nota, string comentario)
        {
            Avaliacao = new Avaliacao(nota, comentario);
        }
    }
}
