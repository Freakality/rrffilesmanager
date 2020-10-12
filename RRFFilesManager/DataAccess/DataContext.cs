using System.Data.Entity;
using System;
using System.IO;
using RRFFilesManager.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class DataContext : DbContext
    {
 
        public DataContext() : base("DefaultConnection") {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<MatterType> MatterTypes { get; set; }
        public DbSet<MatterSubType> MatterSubTypes { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<HearAboutUs> HearAboutUs { get; set; }
        public DbSet<MobileCarrier> MobileCarriers { get; set; }
        public DbSet<Intake> Intakes { get; set; }
    }
}
