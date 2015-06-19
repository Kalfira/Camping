using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQueryUI.Models;

namespace jQueryUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Find(string term)
        {
            var products = new List<Product> {
                new Product {Id=1, Name="Apples"},
                new Product {Id=2, Name="Apricots"},
                new Product {Id=3, Name="Antelopes"},
                new Product {Id=4, Name="Salt"},
                new Product {Id=5, Name="Sugar"},
                new Product {Id=6, Name="Sand"},
                new Product {Id=7, Name="Sardines"}
            };
            var matches = products
                .Where(p => p.Name.StartsWith(term, StringComparison.InvariantCultureIgnoreCase))
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();
            return Json(matches, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Movies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie{Id = 1, Title = "Star Wars"},
                new Movie{Id = 2, Title = "King Kong"},
                new Movie{Id = 3, Title = "Momento"}
            };

            return View(movies);
        }
    }
}