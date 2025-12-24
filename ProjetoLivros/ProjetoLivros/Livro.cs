namespace ProjetoLivros
{
    abstract class Livro
    {
        //Construtor
        public Livro(string titulo, Autor autor, int paginas) 
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        //Variaveis
        private List<Capitulo> capituloList = new List<Capitulo>();

        //Propriedades
        public string Titulo{ get; }
        public Autor Autor{ get; }
        public int TotalCap => capituloList.Count;
        public int Paginas { get; }
        public bool Lido { get; set; }
        public string LivroAutor => $"{Titulo} by {Autor}";

        //Métodos
        public void FichaLivro()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Pagínas: {Paginas}");
            if (Lido == true)
            {
                Console.WriteLine("Livro Lido");
            }
            else
            {
                Console.WriteLine("Livro não Lido");
            }
        }

        public void AddCapitulo(Capitulo capitulo)
        { 
            capituloList.Add(capitulo);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor.Nome}, \nCapitulos: ");

            foreach (var cap in capituloList.OrderBy(e => e.NumeroCap))
            {
                Console.WriteLine(" " + cap.Titulo);
            }

            Console.WriteLine($"Total de Capitulos: {TotalCap}");
        }
    }
}
