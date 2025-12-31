using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros.Banco
{
    internal class ColecaoDAL
    {
        public IEnumerable<Colecao> ListarColecoes()
        {
            using var context = new BibliotecaContext();

            return context.Colecoes.ToList();
        }
    }
}