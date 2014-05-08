using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Unity.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Unity.Models
{
    public class UnityContext : IdentityDbContext

    {
        public UnityContext() : base("UnityContext")
        {

        }

        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<Meetings> Meetings { get; set; }
    }
}