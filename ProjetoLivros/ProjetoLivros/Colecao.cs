namespace ProjetoLivros
{
    public class Colecao
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private List<Livro> livrosNaColecao = new List<Livro>();

        public Colecao()
        {            
        }

        public Colecao(string nomeColecao)
        {
            Nome = nomeColecao;
        }

        internal void AddColecao(Livro livro)
        {
            livrosNaColecao.Add(livro);
        }

        public void ExibirColecao()
        {
            Console.WriteLine($"Coleção: {Nome}");
            foreach (var livro in livrosNaColecao)
            {
                livro.ExibirTitulo();
            }
        }
    }
}
