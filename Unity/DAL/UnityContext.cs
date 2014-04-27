using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Unity.Models;

namespace Unity.DAL
{
    public class UnityContext : DbContext
    {
        public UnityContext() : base("UnityContext")
        {

        }

        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<Meetings> Meetings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}