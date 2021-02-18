using System;
using System.Linq;

namespace MoodyAssignment5.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDBContext _context;

        //constructor
        public EFBookRepository (BookDBContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Book => _context.Book;
    }
}
