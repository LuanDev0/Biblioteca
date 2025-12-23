namespace ProjetoLivros
{
    internal class Leitor
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


    }
}
