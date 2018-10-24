using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace LINQPractice
{
    public class AppDbContext : DbContext
    {

        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";
        
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(ConnectionString); 
        }

        public DbSet<Student> Students {get; set;}
        
        public DbSet<Client> client {get; set;}
        public DbSet<Project> project {get; set;}
        public DbSet<Orginization> Orginization {get; set;}
        public DbSet<Team> team{get; set;} 
    }

}