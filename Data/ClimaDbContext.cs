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
        


        //public bool TestConnectionEF()
        //{
        //    string result;
        //    using (var db = new ClimaDbContext())
        //    {
        //        db.Database.Connection.Open();

        //        if (db.Database.Connection.State == ConnectionState.Open)
        //        {
        //            result = @"INFO: ConnectionString: " + db.Database.Connection.ConnectionString
        //                     + "\n DataBase: " + db.Database.Connection.Database
        //                     + "\n DataSource: " + db.Database.Connection.DataSource
        //                     + "\n ServerVersion: " + db.Database.Connection.ServerVersion
        //                     + "\n TimeOut: " + db.Database.Connection.ConnectionTimeout;

        //            db.Database.Connection.Close();

        //            return true;
        //        }

        //        return false;
        //    }
        //}

    }
}