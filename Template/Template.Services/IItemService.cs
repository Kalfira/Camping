using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Services.Models;

namespace Template.Services
{
    public interface IItemService
    {
        IList<ItemDTO> GetItems();
    }
}
