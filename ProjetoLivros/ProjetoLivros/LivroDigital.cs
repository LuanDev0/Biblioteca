namespace ProjetoLivros
{
    public class LivroDigital : Livro
    {
        //Construtor
        public LivroDigital(string titulo, Autor autor, int paginas, int tamanhoArquivoMb) : base(titulo,autor, paginas)
        {
            TamanhoArquivoMb = tamanhoArquivoMb;
        }

        public LivroDigital() { }

        //Propriedades
        public int TamanhoArquivoMb { get; set; }

        //Métodos        
        public void TamanhoEmMB()
        {
            Console.WriteLine($"Tamanho do arquivo: {TamanhoArquivoMb} MB");
        }

    }
}
