namespace WebApplication7.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication7.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication7.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication7.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));

            if(!context.Roles.Any(r => r.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole { Name = "Admin"});
            }

            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));

            if(!context.Users.Any(u => u.Email == "oongkyu@gmail.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "oongkyu@gmail.com",
                    Email = "oongkyu@gmail.com",
                    FirstName = "Raymond",
                    LastName = "Lee",
                    DisplayName = "Raymond Lee"
                }, "Abc123!");
            }

            if (!context.Roles.Any(r => r.Name == "Moderator"))
            {
                roleManager.Create(new IdentityRole { Name = "Moderator" });
            }

            if (!context.Users.Any(u => u.Email == "lreaves@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "lreaves@coderfoundry.com",
                    Email = "lreaves@coderfoundry.com",
                    FirstName = "L",
                    LastName = "Reaves",
                    DisplayName = "L Reaves"
                }, "Password-1");
            }

            if (!context.Users.Any(u => u.Email == "bdavis@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "bdavis@coderfoundry.com",
                    Email = "bdavis@coderfoundry.com",
                    FirstName = "B",
                    LastName = "Davis",
                    DisplayName = "B Davis"
                }, "Password-1");
            }

            if (!context.Users.Any(u => u.Email == "ajensen@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "ajensen@coderfoundry.com",
                    Email = "ajensen@coderfoundry.com",
                    FirstName = "A",
                    LastName = "Jensen",
                    DisplayName = "A Jensen"
                }, "Password-1");
            }

            if (!context.Users.Any(u => u.Email == "tjones@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "tjones@coderfoundry.com",
                    Email = "tjones@coderfoundry.com",
                    FirstName = "T",
                    LastName = "Jones",
                    DisplayName = "T Jones"
                }, "Password-1");
            }

            if (!context.Users.Any(u => u.Email == "tparrish@coderfoundry.com"))
            {
                userManager.Create(new ApplicationUser
                {
                    UserName = "tparrish@coderfoundry.com",
                    Email = "tparrish@coderfoundry.com",
                    FirstName = "T",
                    LastName = "Parrish",
                    DisplayName = "T Parrish"
                }, "Password-1");
            }

            var userId = userManager.FindByEmail("oongkyu@gmail.com").Id;
            userManager.AddToRole(userId, "Admin");

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
