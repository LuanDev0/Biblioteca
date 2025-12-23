namespace ProjetoLivros
{
    internal class Capitulo
    {
        //Construtor
        public Capitulo(int numeroCap, string titulo, int numeroPag)
        {
            NumeroCap = numeroCap;
            Titulo = titulo;
            NumeroPag = numeroPag;
        }

        //Variaveis
        private List<string> topicos = new List<string>();

        //Propriedades
        public int NumeroCap { get; }
        public string Titulo { get; }
        public int NumeroPag { get; }
        public string resumo  => $"Título do capítulo {Titulo}, número de capítulos {NumeroCap}, " +
            $"quantidade de pagínas {NumeroPag} e tópicos abordados: {string.Join(", ", topicos)}" ;

        //Métodos
        public void AdicionarTopico(string topico)
        {
            topicos.Add(topico);
        }
    }
}
