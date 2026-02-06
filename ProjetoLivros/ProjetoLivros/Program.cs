using ProjetoLivros;
using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;

//Instâncias

Autor autor = new Autor("Kamaitachi");

LivroFisico livro1 = new LivroFisico("Histórias Extraordinárias", autor, 447, true, 50.10);
LivroDigital livro2 = new LivroDigital("Mitologia Nórdica", autor, 286, 127);

Colecao colecao1 = new Colecao("Favoritos");

Colecao colecao2 = new Colecao("Meia bomba");

Colecao colecao3 = new Colecao("Não li");

BancoDados bancoDados = new BancoDados();

var context = new BibliotecaContext();

DAL<Colecao> colecaoDAL = new DAL<Colecao>(context);

//Setando valores
livro1.Lido = false;
livro2.Lido = true;

colecao1.AddColecao(livro1);
colecao1.AddColecao(livro2);

colecao2.AddColecao(livro1);
colecao2.AddColecao(livro2);

colecao3.AddColecao(livro1);
colecao3.AddColecao(livro2);

colecaoDAL.Adicionar(colecao1);
colecaoDAL.Adicionar(colecao2);
colecaoDAL.Adicionar(colecao3);

//var colecoes = colecaoDAL.RecuperarPor(x => x.Id == 1);

//if (colecao != null)
//{
//    Console.WriteLine($"{colecao.Id} - {colecao.Nome}");
//}
//else
//{
//    Console.WriteLine("Coleção não encontrada");
//}

