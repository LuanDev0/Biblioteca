namespace ProjetoLivros
{
    public class Colecao
    {
        public string NomeColecao { get; set; }

        private List<Livro> livrosNaColecao = new List<Livro>();

        public Colecao(string nomeColecao)
        {
            NomeColecao = nomeColecao;
        }

        internal void AddColecao(Livro livro)
        {
            livrosNaColecao.Add(livro);
        }

        public void ExibirColecao()
        {
            Console.WriteLine($"Coleção: {NomeColecao}");
            foreach (var livro in livrosNaColecao)
            {
                livro.ExibirTitulo();
            }
        }
    }
}
