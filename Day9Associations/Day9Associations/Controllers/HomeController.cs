using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day9Associations.Models;


namespace Day9Associations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MovieViewModel> movies = null;
            using (MoviesDbContext db = new MoviesDbContext())
            {
                movies = db.Movies.Include(m => m.Category).ToList();
            };
            return View(movies);
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
    }
}