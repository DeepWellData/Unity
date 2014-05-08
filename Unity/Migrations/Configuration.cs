namespace Unity.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Unity.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Unity.Models.UnityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Unity.Models.UnityContext context)
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

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "cwheeler"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "cwheeler" };

                manager.Create(user, "4356370513");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "cscholes"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "cscholes" };

                manager.Create(user, "chrisis#1");
                manager.AddToRole(user.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "odearkell"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "odearkell" };

                manager.Create(user, "doogie78");
                manager.AddToRole(user.Id, "Admin");
            }

            //var meetings = new List<Meetings>
            //{
            //    new Meetings{Name = "Monday winners", Location = "344 e 300 n Logan, UT", MapLink = "", BeginDateTime = DateTime.Parse("1/1/2015 19:00:00")},
            //    new Meetings{Name = "Tuesday wild horse", Location = "Church on 400 West 1000 North", MapLink = "", BeginDateTime = DateTime.Parse("1/1/2015 20:00:00")},
            //    new Meetings{Name = "Wednesday Book Readers", Location = "Ye old Whittier Center", MapLink = "", BeginDateTime = DateTime.Parse("1/1/2015 01:00:00")},
            //    new Meetings{Name = "Thurday Snoozers", Location = "Your moms place", MapLink = "",  BeginDateTime = DateTime.Parse("1/2/2015 19:00:00")},
            //    new Meetings{Name = "Saturday Breakfast Champs", Location = "1000 North 60 West (behind Wallgreens)", MapLink = "",  BeginDateTime = DateTime.Parse("1/3/2015 19:00:00")},
            //};

            //meetings.ForEach(m => context.Meetings.Add(m));
            //context.SaveChanges();

            //var announcements = new List<Announcements>
            //{
            //    new Announcements{Description = "The coolest activity in Logan. Food, Fun, and Family. Boyahha June 22nd and Pioneer Park.", Expiration = DateTime.Now},
            //    new Announcements{Description = "Fish-N-Pig weekend June 4-6", Expiration = DateTime.Now},
            //    new Announcements{Description = "Gay day in the park be there and it will be dumb as ever.", Expiration = DateTime.Now},
            //    new Announcements{Description = "First original.. never mind some people dont have their own ideas.", Expiration = DateTime.Now},
            //    new Announcements{Description = "Ogdens annual Convention. NUANA kick off speaker Jam!!!!!", Expiration = DateTime.Now},
            //};

            //announcements.ForEach(a => context.Announcements.Add(a));
            //context.SaveChanges();
        }
    }
}
