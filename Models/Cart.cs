using System;
using System.Collections.Generic;
using System.Linq;

namespace MoodyAssignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //add item to cart
        public void AddItem (Book book, int qty) //int price)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookID == book.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty,
                    //Price = price
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }
        //remove line
        public void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookID == book.BookID);

        //clear everything
        public void Clear() => Lines.Clear();

        public decimal CoomputeTotalSum() =>
            (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);
        //price is hardcoded

        //the cart
        public class CartLine
        {
            public int CartLineID { get; set; }

            public Book Book { get; set; }

            public int Quantity { get; set; }

            //public decimal Price { get; set; }
        }
    }
}
