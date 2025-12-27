namespace ProjetoLivros
{
    internal class LivroDigital : Livro
    {
        //Construtor
        public LivroDigital(string titulo, Autor autor, int paginas, int tamanhoArquivoMb) : base(titulo,autor, paginas)
        {
            TamanhoArquivoMb = tamanhoArquivoMb;
        }

        //Propriedades
        public int TamanhoArquivoMb { get; }

        //Métodos        
        public void TamanhoEmMB()
        {
            Console.WriteLine($"Tamanho do arquivo: {TamanhoArquivoMb} MB");
        }

        public override void ExibirTitulo()
        {
            Console.WriteLine($"Titulo : {Titulo}");
        }


    }
}
