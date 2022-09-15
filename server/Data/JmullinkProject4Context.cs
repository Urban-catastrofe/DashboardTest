using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using DashboardTest.Models.JmullinkProject4;

namespace DashboardTest.Data
{
    public partial class JmullinkProject4Context : Microsoft.EntityFrameworkCore.DbContext
    {
        public JmullinkProject4Context(DbContextOptions<JmullinkProject4Context> options) : base(options)
        {
        }

        public JmullinkProject4Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var Connectionstring = "Server=gcmsi.nl;Database=jmullink_Geluidsmeting;Uid=jmullink_Project4;Pwd=Geluid;Connection Timeout=30";
                optionsBuilder.UseMySql(Connectionstring, ServerVersion.AutoDetect(Connectionstring));
            }
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DashboardTest.Models.JmullinkProject4.MicAlex>().HasNoKey();
            builder.Entity<DashboardTest.Models.JmullinkProject4.MicJori>().HasNoKey();
            builder.Entity<DashboardTest.Models.JmullinkProject4.MicKay>().HasNoKey();

            builder.Entity<DashboardTest.Models.JmullinkProject4.MicAlex>()
                  .Property(p => p.Timestamp)
                  .HasDefaultValueSql("current_timestamp()");

            builder.Entity<DashboardTest.Models.JmullinkProject4.MicJori>()
                  .Property(p => p.Timerstamp)
                  .HasDefaultValueSql("current_timestamp()");

            builder.Entity<DashboardTest.Models.JmullinkProject4.MicKay>()
                  .Property(p => p.Timestamp)
                  .HasDefaultValueSql("current_timestamp()");

            this.OnModelBuilding(builder);
        }


        public DbSet<DashboardTest.Models.JmullinkProject4.MicAlex> MicAlexes
        {
            get;
            set;
        }

        public DbSet<DashboardTest.Models.JmullinkProject4.MicJori> MicJoris
        {
            get;
            set;
        }

        public DbSet<DashboardTest.Models.JmullinkProject4.MicKay> MicKays
        {
            get;
            set;
        }
    }
}
