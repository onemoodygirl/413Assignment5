using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MoodyAssignment5.Models;

namespace MoodyAssignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository repo)
        {
            repository = repo;
        }

        //this is to help print out the list of categories

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCat = RouteData?.Values["category"];

            return View(repository.Book
                .Select(x => x.Cat)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
