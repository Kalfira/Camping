using Xadvertise.Models;

namespace Xadvertise.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Xadvertise.Models.AccountsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Xadvertise.Models.AccountsContext context)
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
            context.Accounts.AddOrUpdate(
                new Account{ CompanyName = "Xerox", Cost = 5000.00, Manager = "Jeff", ManagerContact = "jeff@xerox.com", StartDate = DateTime.Parse("01/05/1990")},
                new Account{CompanyName = "Xacme", Manager = "Whiley", ManagerContact = "getthatbird@xacme.com", Cost = 400.00, StartDate = DateTime.Parse("07/04/2014")},
                new Account{CompanyName = "Xbox", Manager = "Balmer", ManagerContact = "gethyped@notmicrosoft.com", Cost = 99999.99, StartDate = DateTime.Today}
                );
        }
    }
}
