using System;
using Microsoft.AspNetCore.Mvc;
using MoodyAssignment5.Models;

namespace MoodyAssignment5.Components
{
    public class CartSummaryViewComponents : ViewComponent
    {
        private Cart Cart;

        public CartSummaryViewComponents(Cart CartService)
        {
            Cart = CartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(Cart);
        }
    }
}