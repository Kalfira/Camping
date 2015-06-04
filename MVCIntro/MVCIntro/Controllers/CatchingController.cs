using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class CatchingController : Controller
    {
        // GET: Catching
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test(string entry)
        {
            ViewBag.Message = entry;

            return View();
        }
    }
}