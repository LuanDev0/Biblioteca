namespace ProjetoLivros.Modelos
{
    public class Livro
    {
        //Construtor
        public Livro(string titulo, Autor autor, int paginas) 
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        public Livro() {}

        //Variaveis
        private List<Capitulo> capituloList = new List<Capitulo>();

        //Propriedades
        public int Id { get; set; } 
        public string Titulo{ get; set; }
        public int TotalCap => capituloList.Count;
        public int Paginas { get; set; }
        public bool Lido { get; set; }
        public string LivroAutor => $"{Titulo} by {Autor}";
        public Autor Autor{ get; set; }
        public Avaliacao Avaliacao { get;  set; }
        public Box Box { get;  set; }
        public int? AutorId { get; set; }
        public int? AvaliacaoId { get; set; }
        public int? BoxId { get; set; }

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

        public void AvaliarLivro(int nota, string comentario)
        {
            Avaliacao = new Avaliacao(nota, comentario);
        }

        public virtual void DetalhesAdicionais()
        {
            Console.WriteLine("Detalhes adicionais não disponíveis para este tipo de livro.");
        }
    }
}
