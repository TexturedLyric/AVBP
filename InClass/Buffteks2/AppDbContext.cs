using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Buffteks2
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
        public DbSet<client> client {get; set;}
        public DbSet<project> project {get; set;}
        public DbSet<Orginization> Orginization {get; set;}
        public DbSet<team> team{get; set;} 

    }

}