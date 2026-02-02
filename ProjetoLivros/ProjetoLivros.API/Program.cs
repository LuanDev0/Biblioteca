using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var dal = new DAL<Colecao>(new BibliotecaContext());
    return dal.RecuperarPor(c => c.Id == 1);
});

app.MapGet("/Colecoes/{Nome}", (string Nome) =>
{
    var dal = new DAL<Colecao>(new BibliotecaContext());
    return dal.RecuperarPor(c => c.Nome.ToUpper().Equals(Nome.ToUpper()) );
});

app.Run();
