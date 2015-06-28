using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitAbridged.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DetailsId { get; set; }
        [ForeignKey("DetailsId")]
        public virtual Details Details { get; set; }
    }
}