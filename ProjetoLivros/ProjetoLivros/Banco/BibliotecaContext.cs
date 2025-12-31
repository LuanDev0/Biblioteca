using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros.Banco
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Colecao> Colecoes { get; set; }

        private string connectionString = "Data Source=localhost;Initial Catalog=Biblioteca;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
