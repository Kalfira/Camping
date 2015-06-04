using System.Collections.Generic;
using System.Web.Mvc;
using StronglyTypedViews.Models;

namespace StronglyTypedViews.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Name = "Milk", Price = 2.33m},
                new Product(){Name = "Eggs", Price = 1.09m},
                new Product(){Name = "Cheese", Price = 12.00m}
            };
            IndexViewModel vm = new IndexViewModel()
            {
                Products = products
            };
            return View(vm);
        }
    }
}