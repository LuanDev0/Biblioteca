using ProjetoLivros;

namespace ProjetoLivros
{
    public class Autor : IGeneroPreferido
    {
        //Construtor
        public Autor(string nome)
        {
            Nome = nome;
        }

        public Autor() { }

        //Variaveis
        private List<Box> Box = new List<Box>();

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string GeneroPreferido { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public int? AvaliacaoId { get; set; }

        //Métodos
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