using System.Collections.Generic;
using System.Linq;

namespace StronglyTypedViews.Models
{
    public class IndexViewModel
    {
        public IList<Product> Products { get; set; }

        public decimal GetTotal(List<Product> productsList)
        {
            return productsList.Sum(product => product.Price);
        }
    }
}