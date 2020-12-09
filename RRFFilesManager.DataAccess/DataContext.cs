using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using RRFFilesManager.Abstractions;
using System.Configuration;

namespace RRFFilesManager.DataAccess
{
    public class DataContext : DbContext
    {
 
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<MatterType> MatterTypes { get; set; }
        public DbSet<MatterSubType> MatterSubTypes { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<HearAboutUs> HearAboutUs { get; set; }
        public DbSet<MobileCarrier> MobileCarriers { get; set; }
        public DbSet<RRFFilesManager.Abstractions.File> Files { get; set; }
        public DbSet<Intake> Intakes { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<DisabilityInsuranceCompany> DisabilityInsuranceCompanies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }

        //Add-Migration Initial_EFCore -Context DataContext -Project RRFFilesManager.DataAccess
        //Update-Database -Context DataContext -Project RRFFilesManager.DataAccess
    }
}
