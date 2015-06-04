using System.Collections.Generic;

namespace StronglyTypedViews.Models
{
    public class ShoppingListService
    {
        public IList<Customer> Customers { get; set; }
        public static decimal GetTotal(List<Product> productsList)
        {
            decimal total = 0;
            foreach (Product product in productsList)
            {
                total += product.Price;
            }
            return total;
        }
    }
}