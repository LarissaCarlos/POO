using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class DataContext : DbContext
    {
        protected string DbPath { get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "MeuBanco.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<As_Biblioteca.Domain.Entities.Autor> DbSetAutor { get; set; }
        public DbSet<As_Biblioteca.Domain.Entities.Livro> DbSetLivro { get; set; }
        public DbSet<As_Biblioteca.Domain.Entities.Usuario> DbSetUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}