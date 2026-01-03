using ProjetoLivros;
using ProjetoLivros.Banco;

//Instâncias
Autor autor = new Autor("Kamaitachi");

LivroFisico livro1 = new LivroFisico("Histórias Extraordinárias", autor, 447, true, 50.10);
LivroDigital livro2 = new LivroDigital("Mitologia Nórdica", autor, 286, 127);

Colecao colecao = new Colecao("Piores dos melhores") {Id = 2003};

BancoDados bancoDados = new BancoDados();

var context = new BibliotecaContext();

DAL<Colecao> colecaoDAL = new DAL<Colecao>(context);

//Setando valores
livro1.Lido = false;
livro2.Lido = true;

colecao.AddColecao(livro1);
colecao.AddColecao(livro2);

colecaoDAL.Atualizar(colecao);

var colecoes = colecaoDAL.RecuperarPor(x => x.Id == 3);

if (colecao != null)
{
    Console.WriteLine($"{colecao.Id} - {colecao.Nome}");
}
else
{
    Console.WriteLine("Coleção não encontrada");
}