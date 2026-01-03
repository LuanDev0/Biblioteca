using Microsoft.EntityFrameworkCore;

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
