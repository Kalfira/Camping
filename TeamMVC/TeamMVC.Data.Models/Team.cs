using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMVC.Data.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
