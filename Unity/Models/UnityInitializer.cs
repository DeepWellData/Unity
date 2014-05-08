using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Unity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Unity.DAL
{
    public class UnityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UnityContext>
    {
        protected override void Seed(UnityContext context)
        {
            var meetings = new List<Meetings>
            {
                new Meetings{Name = "Monday winners", Location = "344 e 300 n Logan, UT", MapLink = "", DayofWeek = Days.Monday, TimeofDay = "7pm"},
                new Meetings{Name = "Tuesday wild horse", Location = "Church on 400 West 1000 North", MapLink = "", DayofWeek = Days.Tuesday, TimeofDay = "7pm"},
                new Meetings{Name = "Wednesday Book Readers", Location = "Ye old Whittier Center", MapLink = "", DayofWeek = Days.Wednesday, TimeofDay = "7pm"},
                new Meetings{Name = "Thurday Snoozers", Location = "Your moms place", MapLink = "", DayofWeek = Days.Thursday, TimeofDay = "7pm"},
                new Meetings{Name = "Saturday Breakfast Champs", Location = "1000 North 60 West (behind Wallgreens)", MapLink = "", DayofWeek = Days.Saturday, TimeofDay = "7pm"}
            };

            meetings.ForEach(m => context.Meetings.Add(m));
            context.SaveChanges();

            var announcements = new List<Announcements>
            {
                new Announcements{Description = "The coolest activity in Logan. Food, Fun, and Family. Boyahha June 22nd and Pioneer Park.", Expiration = DateTime.Now},
                new Announcements{Description = "Fish-N-Pig weekend June 4-6", Expiration = DateTime.Now},
                new Announcements{Description = "Gay day in the park be there and it will be dumb as ever.", Expiration = DateTime.Now},
                new Announcements{Description = "First original.. never mind some people dont have their own ideas.", Expiration = DateTime.Now},
                new Announcements{Description = "Ogdens annual Convention. NUANA kick off speaker Jam!!!!!", Expiration = DateTime.Now},
            };

            announcements.ForEach(a => context.Announcements.Add(a));
            context.SaveChanges();
        }
    }
}