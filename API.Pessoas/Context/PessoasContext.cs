using API.Pessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Pessoas.Context
{
    public class PessoasContext : DbContext
    {
        public PessoasContext(DbContextOptions<PessoasContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Pessoa>()
                .HasMany(x => x.Amigos);
        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
