using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoLivros.Banco
{
    public class DAL<T> where T : class
    {
        protected readonly BibliotecaContext context;

        public DAL(BibliotecaContext context)
        {
            this.context = context;
        }

        public void Adicionar(T objeto)
        {
            context.Set<T>().Add(objeto);
            context.SaveChanges();
        }

        public void Atualizar(T objeto)
        {
            context.Set<T>().Update(objeto);
            context.SaveChanges();
        }

        public void Remover(T objeto)
        {
            context.Set<T>().Remove(objeto);
            context.SaveChanges();        
        }

        public T? RecuperarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().FirstOrDefault(condicao);
        }

        public IEnumerable<T> ListaRecuperarPor(Func<T, bool> condicao)
        {
            return context.Set<T>().Where(condicao).ToList();
        }
    }
}
