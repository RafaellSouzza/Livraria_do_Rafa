using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Livraria;
using Microsoft.Extensions.Configuration;

namespace Livraria
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
           
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<LivroCategoria> LivroCategoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroCategoria>()
                .HasKey(cp => new { cp.LivroId, cp.CategoriaId });
        }
    }
}