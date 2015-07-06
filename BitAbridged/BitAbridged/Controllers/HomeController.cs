using System;
using System.Web;
using System.Web.Mvc;

namespace BitAbridged.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        //Deprecated
        public ActionResult Logout()
        {
            HttpCookie _cookie = new HttpCookie(".AspNet.Cookies");
            _cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(_cookie);
            return Redirect("~/#/logout");
        }
    }
}
