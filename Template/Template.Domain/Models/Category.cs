using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Template.Domain.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
