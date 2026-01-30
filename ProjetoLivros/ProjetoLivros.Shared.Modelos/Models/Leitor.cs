namespace ProjetoLivros.Modelos
{
    public class Leitor : IGeneroPreferido
    {
        //Construtor
        public Leitor(String nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Leitor() { }

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public string GeneroPreferido { get; set; }
        public int? AvaliacaoId { get; set; }


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
