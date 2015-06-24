using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NicksCafe.Models;

namespace NicksCafe.Controllers.api
{
    public class MenuController : ApiController
    {
        private static IList<Product> _products;

        static MenuController()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Test Product", Description = "Lorem Ipsum", IsBreakfast = false, Price = .99m }
            };
        }

        public IList<Product> Get()
        {
            return _products;
        }

        public bool Post(Product product)
        {
            _products.Add(product);
            return true;
        }
    }
}
