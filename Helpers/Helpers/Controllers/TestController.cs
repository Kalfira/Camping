using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.Message = "This is a test";
            
            return View();
        }
    }
}