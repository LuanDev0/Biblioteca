using ProjetoLivros.Banco;
using ProjetoLivros.Modelos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var dal = new DAL<Colecao>(new BibliotecaContext());
    return dal.RecuperarPor(c => c.Id == 1);
});

app.Run();
