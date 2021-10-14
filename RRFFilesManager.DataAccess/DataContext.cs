using Microsoft.EntityFrameworkCore;
using RRFFilesManager.Abstractions;
using System.Configuration;

namespace RRFFilesManager.DataAccess
{
    public class DataContext : DbContext
    {
 
        public DataContext() : base() { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<MatterType> MatterTypes { get; set; }
        public DbSet<MatterSubType> MatterSubTypes { get; set; }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<HearAboutUs> HearAboutUs { get; set; }
        public DbSet<MobileCarrier> MobileCarriers { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Archive> Archives { get; set; }
        public DbSet<Intake> Intakes { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<DisabilityInsuranceCompany> DisabilityInsuranceCompanies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<FileContact> FileContacts { get; set; }
        public DbSet<DocumentGroup> DocumentGroups { get; set; }
        public DbSet<DocumentCategory> DocumentCategories { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<UploadArchivesSettings> UploadArchivesSettings { get; set; }
        public DbSet<ComissionCalculator> ComissionCalculator { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<OutOfPocketHealthCareExp> OutOfPocketHealthCareExp { get; set; }
        public DbSet<MedicalSummary> MedicalSummaries { get; set; }
        public DbSet<ComissionSubType> ComissionSubTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileContact>().HasKey(sc => new { sc.FileId, sc.ContactId });
        }


        //Add-Migration Initial_EFCore -Context DataContext -Project RRFFilesManager.DataAccess
        //Update-Database -Context DataContext -Project RRFFilesManager.DataAccess
    }
}
