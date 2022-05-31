using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApi_Common.Models;

namespace WebApi_Server_Konyvtar.Repositories
{
    public class BookContext : DbContext
    {
        
        public BookContext()
        {
            
        }
        public BookContext([NotNull]DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> book{ get; set; }
    }
}
