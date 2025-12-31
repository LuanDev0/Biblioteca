namespace ProjetoLivros
{
    public class Box
    {
        //Construtor
        public Box(string nome)
        {
            Nome = nome;
        }

        public Box() {}

        //Variaveis
        private List<Livro> livros = new List<Livro>();

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
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