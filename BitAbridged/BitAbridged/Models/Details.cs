using System.ComponentModel.DataAnnotations;

namespace BitAbridged.Models
{
    public class Details
    {
        [Key]
        public int Id { get; set; }

        public string Fact1 { get; set; }
        public string Fact2 { get; set; }

    }
}