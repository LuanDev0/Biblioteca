using Microsoft.EntityFrameworkCore;
using ProjetoLivros.Modelos;

namespace ProjetoLivros.Banco
{
    public class BibliotecaContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Box> Boxes { get; set; }
        public DbSet<Capitulo> Capitulos { get; set; }
        public DbSet<Colecao> Colecoes { get; set; }
        public DbSet<Leitor> Leitores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroFisico> LivrosFisicos { get; set; }
        public DbSet<LivroDigital> LivrosDigitais { get; set; }

        private string connectionString = "Data Source=localhost;Initial Catalog=Biblioteca;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>()
                .HasDiscriminator<string>("TipoLivro")
                .HasValue<LivroDigital>("Digital")
                .HasValue<LivroFisico>("Fisico");
        }
    }
}
