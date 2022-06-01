using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApi_Common.Models;

namespace WebApi_Server_Konyvtar.Repositories
{
    public class BookContext : DbContext
    {
       
        public DbSet<Book> book{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\mssqllocaldb;Database=ServerDb;Integrated Security=True;");
        }
    }
}
