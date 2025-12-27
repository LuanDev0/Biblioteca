namespace ProjetoLivros
{
    internal class Autor : IGeneroPreferido
    {
        //Construtor
        public Autor(string nome)
        {
            Nome = nome;
        }

        //Variaveis
        private List<Box> Box = new List<Box>();

        //Propriedades
        public string Nome { get;}
        public string GeneroPreferido { get; private set; }
        public Avaliacao Avaliacao { get; private set; }

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
