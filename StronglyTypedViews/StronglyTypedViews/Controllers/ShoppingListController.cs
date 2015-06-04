using System.Collections.Generic;
using System.Web.Mvc;
using StronglyTypedViews.Models;

namespace StronglyTypedViews.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Name = "Milk", Price = 2.33m},
                new Product(){Name = "Eggs", Price = 1.09m},
                new Product(){Name = "Cheese", Price = 12.00m}
            };
            
            List<Customer> cust = new List<Customer>()
            {
                new Customer(){FirstName = "Zane", LastName = "Degner", ListOfProducts = products, Total = ShoppingListService.GetTotal(products)}
            };
            ShoppingListService vm = new ShoppingListService()
            {
                Customers = cust
            };
            
            return View(vm);
        }
    }
}