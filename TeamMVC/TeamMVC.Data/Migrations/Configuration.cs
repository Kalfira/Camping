using TeamMVC.Data.Models;

namespace TeamMVC.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamMVC.Data.TeamDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamMVC.Data.TeamDbContext context)
        {

            Team team1 = new Team {City = "Houston",Name = "Astros"};

            context.Teams.AddOrUpdate(t => new {t.Name, t.City}, team1);
            context.SaveChanges();

            context.Players.AddOrUpdate(p => new{p.FirstName, p.LastName},
                new Player { FirstName = "Jeff", LastName = "Bagwell", TeamId = team1.TeamId},
                new Player { FirstName = "Bob", LastName = "Knepper", TeamId = team1.TeamId},
                new Player { FirstName = "Craig", LastName = "Biggio", TeamId = team1.TeamId}
                );
            context.SaveChanges();
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
        }
    }
}
