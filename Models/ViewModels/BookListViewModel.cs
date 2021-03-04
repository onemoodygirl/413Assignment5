using System;
using System.Collections.Generic;

namespace MoodyAssignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public PagingInfo PagingInfo { get; set; }

        //new thing so you can search for a certain category
        public string CurrentCategory { get; set; }
    }
}
