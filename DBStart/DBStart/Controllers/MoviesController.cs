using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBStart.Models;

namespace DBStart.Controllers
{
    public class MoviesController : Controller
    {
        //Private Class Instance Variable
        private MovieDbContext _db = new MovieDbContext();

        // GET: Movie
        public ActionResult Index()
        {
            IQueryable<Movie> movies = from m in _db.Movies select m;
            return View(movies.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            Movie movie = _db.Movies.Find(id);
            return View(movie);
        }
        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                Movie original = _db.Movies.Find(movie.Id);
                original.Title = movie.Title;
                original.Director = movie.Director;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}