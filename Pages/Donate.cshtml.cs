using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoodyAssignment5.Infrastructure;
using MoodyAssignment5.Models;

namespace MoodyAssignment5.Pages
{
    //add and remove stuff in cart
    public class DonateModel : PageModel
    {
        private IBookRepository repository;

        public DonateModel (IBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }


        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        }

        //adds book to cart
        public IActionResult OnPost(long bookID, string returnUrl)
        {
            Book book = repository.Book.FirstOrDefault(b => b.BookID == bookID);

            //Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();

            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("Cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //remove the line
        public IActionResult OnPostRemove(long bookID, string returnUrl)
        {
            Book book = repository.Book.FirstOrDefault(b => b.BookID == bookID);

            //Cart = HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();

            Cart.RemoveLine(book);

            HttpContext.Session.SetJson("Cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });


            //Cart.RemoveLine(Cart.Lines.First(cl =>
            // cl.Book.BookID == bookID).Book);
            //return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
