using BitAbridged.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace BitAbridged.Migrations
{


    internal sealed class Configuration : DbMigrationsConfiguration<BitAbridged.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BitAbridged.Models.ApplicationDbContext context)
        {
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(context);
            UserManager<ApplicationUser> userManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<Role> roleStore = new RoleStore<Role>(context);
            RoleManager<Role> roleManager = new RoleManager<Role>(roleStore);

            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new Role { Name = "Admin" });

            if (!roleManager.RoleExists("User"))
                roleManager.Create(new Role { Name = "User" });
            ApplicationUser zane = userManager.FindByName("zdegner@gmail.com");

            zane = new ApplicationUser
            {
                Id = "1",
                UserName = "admin",
                Email = "zdegner@gmail.com"
            };
            userManager.Create(zane, "asdf3214");
            userManager.AddToRole(zane.Id, "Admin");
            List<Language> languages = new List<Language>()
            {
                new Language {Id = 1, Name = "C#"},
                new Language {Id = 2, Name = "Python"},
                new Language {Id = 3, Name = "Haskell"}
            };
            foreach (Language language in languages)
            {
                context.Languages.AddOrUpdate(l => l.Name, language);
                context.SaveChanges();
            }

            List<Details> details = new List<Details>
            {
                new Details {Id = 1, Fact1 = "Compiled", Fact2 = "Kickass!", LanguageId = 1},
                new Details {Id = 2, Fact1 = "Interpreted", Fact2 = "Weird Looking", LanguageId = 2},
                new Details {Id = 3, Fact1 = "Functional", Fact2 = "For geniuses only, stay away!", LanguageId = 3}
            };
            foreach (Details detail in details)
            {
                context.Details.AddOrUpdate(d => d.Id, detail);
                context.SaveChanges();
            }


        }
    }
}
