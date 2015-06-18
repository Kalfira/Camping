using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Presentation.Web.Models;
using Template.Services;

namespace Template.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private IItemService _service;

        public HomeController(IItemService service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            ItemViewModel model = new ItemViewModel();
            model.Items = _service.GetItems();

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