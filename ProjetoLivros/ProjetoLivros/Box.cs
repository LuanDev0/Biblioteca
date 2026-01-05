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

        //Propriedades
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();
        public int Id { get; set; }
        public string Nome { get; set; }
        public int MaxPag => Livros.Sum(l => l.Paginas);
        public int QuantidadeLivros => Livros.Count;
        
        //Métodos
        public void AdicionaLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void ExibirLivrosBox()
        {
           foreach(var livro in Livros)
            {
                Console.WriteLine(livro.Titulo);
            }
        }

        public string QuantidadePaginas()
        {
            int maxPag = 0;

            foreach(var livro in Livros)
            {
                maxPag += livro.Paginas;
            }

            return maxPag.ToString();
        }
    }
}