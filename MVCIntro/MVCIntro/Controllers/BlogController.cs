using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult GetEntryByDate(DateTime entryDate, string test)
        {
            return Content("You requested the blog entry for date: "+entryDate.ToLongDateString()+" and "+test);
        }

        public ActionResult GentEntryById(int entryId)
        {
            return Content("You requested the blog entry for id " + entryId.ToString());
        }
    }
}