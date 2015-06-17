using System.Data.Entity;
using Template.Domain.Models;


namespace Template.Infrastructure.Persistance
{
    public class ItemsDbContext : DbContext
    {
        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Item> Items { get; set; }
    }
}
