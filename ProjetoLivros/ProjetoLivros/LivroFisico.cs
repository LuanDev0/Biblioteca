namespace ProjetoLivros
{
    internal class LivroFisico : Livro
    {
        //Construtor
        public LivroFisico(string titulo, Autor autor, int paginas, bool capadura) : base(titulo, autor, paginas)
        {
            CapaDura = capadura;
        }

        public LivroFisico(string titulo, Autor autor, int paginas, bool capadura, double preco) : base(titulo, autor, paginas)
        {
            CapaDura = capadura;
            Preco = preco;
        }

        //Propriedades
        public bool CapaDura { get; }
        public double Preco { get; set; }

        //Métodos
        public void TipoCapa()
        {
            if (CapaDura == true)
            {
                Console.WriteLine("O livro é de capa dura.");
            }
            else
            {
                Console.WriteLine("O livro é de capa Brochura.");
            }
        }
        
        public override void ExibirTitulo()
        {
            Console.WriteLine($"Titulo : {Titulo}");
        }

        public override void DetalhesAdicionais()
        {
            Console.WriteLine("Detalhes adicionais disponíveis.");
        }

    }
}
