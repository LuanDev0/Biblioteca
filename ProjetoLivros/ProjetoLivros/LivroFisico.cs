namespace ProjetoLivros
{
    internal class LivroFisico : Livro
    {
        //Construtor
        public LivroFisico(string titulo, Autor autor, int paginas, bool capadura) : base(titulo, autor, paginas)
        {
            CapaDura = capadura;
        }

        //Propriedades
        public bool CapaDura { get; }

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
    }
}
