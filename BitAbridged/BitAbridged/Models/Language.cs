using System.ComponentModel.DataAnnotations;

namespace BitAbridged.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}