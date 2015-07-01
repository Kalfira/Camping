using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BitAbridged.Models
{
    public class Details
    {
        [Key]
        public int Id { get; set; }
        public string Fact1 { get; set; }
        public string Fact2 { get; set; }
        public int LanguageId { get; set; }
        [ForeignKey("LanguageId")]
        public virtual Language Language { get; set; }


    }
}