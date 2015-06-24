using System.ComponentModel.DataAnnotations;

namespace AngularAjax.Models
{
    public class Food
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Food Name is required fool")]
        public string Name { get; set; }
    }
}