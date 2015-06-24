using AngularAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AngularAjax.Controllers.api
{
    public class FoodController : ApiController
    {
        [Route("api/food/{search}")]
        public IList<Food> Get(string search)
        {
            var all = new List<Food>
            {
                new Food {Id = 1, Name = "Milk"},
                new Food {Id = 2, Name = "Marzipan"},
                new Food {Id = 3, Name = "Mustard"},
                new Food {Id = 4, Name = "Eggs"}
            };

            return all.Where(f => f.Name.StartsWith(search, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public IHttpActionResult Post(Food food)
        {
            if (ModelState.IsValid)
            {
                //Save the food to the database

                return Ok(new { Name = food.Name, Id = 5 });
            }
            else
            {

                return BadRequest(ModelState);
            }
        }
    }
}
