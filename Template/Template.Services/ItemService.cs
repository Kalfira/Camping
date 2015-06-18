using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Models;
using Template.Services.Models;

namespace Template.Services
{
    public class ItemService : IItemService
    {
        private IGenericRepository _repo;
        public ItemService(IGenericRepository repo)
        {
            _repo = repo;
        }
        public IList<ItemDTO> GetItems()
        {
            return _repo.Query<Item>().Select(p => new ItemDTO
            {
                CategoryName = p.Category.Name,
                Details = p.Details,
                ItemName = p.Name
            }).ToList();
        }
    }
}
