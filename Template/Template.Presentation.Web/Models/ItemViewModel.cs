using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Template.Services.Models;

namespace Template.Presentation.Web.Models
{
    public class ItemViewModel
    {
        public IList<ItemDTO> Items { get; set; } 
    }
}