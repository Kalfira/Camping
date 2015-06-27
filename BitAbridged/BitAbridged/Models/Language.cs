using System.Collections.Generic;

namespace BitAbridged.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Info { get; set; }
    }
}