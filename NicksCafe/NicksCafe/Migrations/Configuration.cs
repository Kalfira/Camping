using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using NicksCafe.Models;

namespace NicksCafe.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NicksCafe.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NicksCafe.Models.ApplicationDbContext context)
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

            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);
            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new Role {Name = "Admin"});
            }
            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new Role {Name = "User"});
            }

            ApplicationUser nick = userManager.FindByName("nick@codercamps.com");
            if (nick == null)
            {
                nick = new ApplicationUser
                {
                    UserName = "nick@codercamps.com",
                    Email = "nick@codercamps.com"
                };

                userManager.Create(nick, "123456");
                userManager.AddToRole(nick.Id, "Admin");
                nick = userManager.FindByName("nick@codercamps.com");
            }

            var products = context.Products.Where(p => p.UserId == null);
            foreach (var product in products)
            {
                product.UserId = nick.Id;
            }
        }
    }
}
