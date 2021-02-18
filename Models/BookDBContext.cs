using System;
using Microsoft.EntityFrameworkCore;

namespace MoodyAssignment5.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext (DbContextOptions<BookDBContext> options) : base (options)
        {

        }

        public DbSet<Book> Book { get; set; }
    }
}
