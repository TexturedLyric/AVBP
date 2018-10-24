using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace BuffTeksFinal
{
    public class AppDbContext : DbContext
    {
        //The connection string is used by the SQL Server database provider to find the database
        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";
        
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString); //#B
        }

        public DbSet<Student> Students {get; set;}
        public DbSet<Client> client {get; set;}
        public DbSet<Project> project {get; set;}
        public DbSet<Orginization> Orginization {get; set;}
        public DbSet<Team> team{get; set;} 

    }

}