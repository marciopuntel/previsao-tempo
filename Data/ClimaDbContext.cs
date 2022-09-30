using ClimaTempoSimples.Models;
using System.Data;
using System.Data.Entity;

namespace ClimaTempoSimples.Data
{
    public class ClimaDbContext: DbContext
    {
        public ClimaDbContext(): base("name=ClimaTempoSimples")
        {

        }


        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClima { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>().ToTable("Cidade");
            modelBuilder.Entity<Estado>().ToTable("Estado");
            modelBuilder.Entity<PrevisaoClima>().ToTable("PrevisaoClima");
        }
        

    }
}
