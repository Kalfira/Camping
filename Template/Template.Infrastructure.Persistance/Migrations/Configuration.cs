namespace Template.Infrastructure.Persistance.Migrations
{
    using System.Data.Entity.Migrations;
    using Template.Domain.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Template.Infrastructure.Persistance.ItemsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Template.Infrastructure.Persistance.ItemsDbContext context)
        {
            Category c1 = new Category { Name = "Items" };

            context.Categories.AddOrUpdate(c => c.Name, c1);
            context.SaveChanges();

            context.Items.AddOrUpdate(p => p.Name, new Item
            {
                CategoryId = c1.CategoryId,
                Name = "Item",
                Details = "Lorem Ipsum"
            });
        }
    }
}
