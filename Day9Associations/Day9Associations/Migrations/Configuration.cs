using Day9Associations.Models;

namespace Day9Associations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day9Associations.Models.MoviesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Day9Associations.Models.MoviesDbContext context)
        {
            Category sciFi = new Category{Name = "SciFi"};
            context.Categories.AddOrUpdate(c => c.Name, sciFi);
            Movie starWars = new Movie
            {
                Title = "Star Wars",
                Director = "George Lucas",
                CategoryId = sciFi.Id
            };
            context.Movies.AddOrUpdate(m => m.Title, starWars);

        }
    }
}
