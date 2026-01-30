namespace ProjetoLivros.Modelos
{
    public class Capitulo
    {
        //Construtor
        public Capitulo(int numeroCap, string titulo, int numeroPag)
        {
            NumeroCap = numeroCap;
            Titulo = titulo;
            NumeroPag = numeroPag;
        }

        public Capitulo() { }

        //Variaveis
        private List<string> topicos = new List<string>();

        //Propriedades
        public int Id { get; set; }
        public int NumeroCap { get; set; }
        public string Titulo { get; set; }
        public int NumeroPag { get; set; }
        public string resumo  => $"Título do capítulo {Titulo}, número de capítulos {NumeroCap}, " +
            $"quantidade de pagínas {NumeroPag} e tópicos abordados: {string.Join(", ", topicos)}" ;

        //Métodos
        public void AdicionarTopico(string topico)
        {
            topicos.Add(topico);
        }
    }
}
