using System;
using System.Linq;

namespace MoodyAssignment5.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Book { get; } 
    }
}
