using System.Collections.Generic;
using DBStart.Models;

namespace DBStart.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DBStart.Models.MovieDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DBStart.Models.MovieDbContext";
        }

        protected override void Seed(DBStart.Models.MovieDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var movies = new Movie[]
            {
                new Movie() {Title = "Star Wars", Director = "Lucas"},
                new Movie() {Title = "Memento", Director = "Nolan"},
                new Movie() {Title = "King Kong", Director = "Jackson"}
            };

            context.Movies.AddOrUpdate(m => m.Title, movies);
        }
    }
}
