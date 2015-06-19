using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IntroAPI.Models;

namespace IntroAPI.Controllers.API
{
    public class ProductsController : ApiController
    {
        private static ConcurrentStack<Product> _products; 
        // GET: api/Products
        static ProductsController()
        {
            _products = new ConcurrentStack<Product>(new List<Product>
            {
                new Product {Name = "Milk", Price = 2.33m},
                new Product{Name="Cheese", Price = 55.33m},
                new Product{Name = "Tesla", Price = 8989.33m}
            });
        }

        // GET: api/Products/5
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        // POST: api/Products
        public HttpResponseMessage Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _products.Push(product);
                return Request.CreateResponse(HttpStatusCode.Created, product);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, this.ModelState);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
