using System.Collections.Generic;

namespace StronglyTypedViews.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Product> ListOfProducts { get; set; }
        public decimal Total { get; set; }
    }
}