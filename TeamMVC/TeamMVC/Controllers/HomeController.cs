using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using TeamMVC.Data;
using TeamMVC.Data.Models;
using TeamMVC.Models;
using TeamMVC.Repositories;

namespace TeamMVC.Controllers
{
    public class HomeController : Controller
    {
        private IGenericRepository _repo;

        public HomeController(IGenericRepository repo)
        {
            _repo = repo;
        }
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Players = _repo.Query<Player>().Project().To<PlayerViewModel>().ToList();
                
                //.Select(p => new PlayerViewModel
                //{
                //    PlayerName = p.FirstName + " " + p.LastName,
                //    TeamCity = p.Team.City,
                //    TeamName = p.Team.Name
                //}).ToList();
            model.NumberOfPlayers = model.Players.Count;
            return View(model);
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