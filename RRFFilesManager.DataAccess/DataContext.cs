using Microsoft.EntityFrameworkCore;
using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Objects;
using System.Linq;
using System.Reflection;

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
        public DbSet<FileReview> FileReviews { get; set; }
        public DbSet<StandardBenefitRow> StandardBenefitRows { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<FileTask> FileTasks { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<TaskCategory> TaskCategories { get; set; }
        public DbSet<TaskDependency> TaskDependencies { get;  set; }
        public DbSet<LogItem> LogItems { get; set; }
        public DbSet<Timeline> Timelines { get; set; }
        public Lawyer User { get; set; }


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
            modelBuilder.Entity<TaskDependency>().HasKey(x => new { x.TaskId, x.DependencyId });

            modelBuilder.Entity<TaskDependency>()
                .HasOne(x => x.Task)
                .WithMany(y => y.Dependencies)
                .HasForeignKey(x => x.TaskId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public override int SaveChanges()
        {
            var changes = ChangeTracker.Entries().Where(p => p.State == EntityState.Modified || p.State == EntityState.Added || p.State == EntityState.Deleted).ToList();
            /*var changes = Extensions.DetailedCompare<File>(file, trxFile);*/
            string description = "";// $"Updated File {file.ToString()} with the following changes: ";
            bool notfirst = false;

            foreach (var v in changes)
            {
                if (notfirst)
                    description += ". ";
                var entityType = ObjectContext.GetObjectType(v.Entity.GetType());
                if (entityType.BaseType.Name == "LogItem")
                    return base.SaveChanges();
                var state = v.State;
                switch (state)
                {
                    case EntityState.Modified:
                        description = $"Updated {entityType.BaseType.Name} {v.Entity.ToString()} with the following changes: ";
                        break;
                    case EntityState.Added:
                        description = $"Created {entityType.Name} {v.Entity.ToString()}.";
                        break;
                    case EntityState.Deleted:
                        description = $"Deleted {entityType.Name} {v.Entity.ToString()}.";
                        break;
                }
                if (state == EntityState.Modified)
                {
                    foreach (var prop in v.OriginalValues.Properties)
                    {
                        /*if (prop.Name == "SubTypeCategory")
                        {
                            Console.WriteLine("Hi");
                        }*/

                        string propname = prop.Name;
                        if (propname.EndsWith("ID") && propname != "ID")
                        {
                            propname = propname.Substring(0, propname.Length - 2);
                        }
                        PropertyInfo propertyInfo = entityType.GetProperty(propname);
                        if (propertyInfo is null)
                        {
                            continue;
                        }
                        Type propertyType = propertyInfo.PropertyType;
                        string originalValue = "";
                        string currentValue = "";
                        if (!(v.OriginalValues[prop] is null))
                        {
                            originalValue = v.OriginalValues[prop].ToString();
                        }
                        if (!(v.CurrentValues[prop] is null))
                        {
                            currentValue = v.CurrentValues[prop].ToString();
                        }
                        if (currentValue != null && originalValue != null)
                            continue;
                        if (originalValue != currentValue)
                        {
                            if (notfirst)
                                description += ", ";
                            originalValue = GetValueName(propertyType.Name, originalValue);
                            currentValue = GetValueName(propertyType.Name, currentValue);
                            description += $"{propname}: {originalValue} -> {currentValue}";
                            if (!notfirst)
                                notfirst = true;

                        }
                    }

                }
                else
                {
                    foreach (var prop in v.CurrentValues.Properties)
                    {
                        string propname = prop.Name;
                        if (propname.EndsWith("ID") && propname != "ID")
                            propname = propname.Substring(0, propname.Length - 2);
                        if (propname == "ID")
                            continue;
                        PropertyInfo propertyInfo = entityType.GetProperty(propname);
                        Type propertyType = propertyInfo.PropertyType;
                        var value1 = v.CurrentValues[prop];
                        if (value1 != null)
                        {
                            string value = value1.ToString();
                            if (notfirst)
                                description += ", ";
                            value = GetValueName(propertyType.Name, value);
                            description += $"{propname}: {value}";
                            if (!notfirst)
                                notfirst = true;
                        }
                    }
                }

            }
            if (description != "")
            {
                LogItem logItem = new LogItem();
                logItem.Date = DateTime.Now;
                logItem.Description = description;
                logItem.Lawyer = User;
                LogItems.Add(logItem);
            }
            return base.SaveChanges();
        }

        public string GetValueName(string propertyname, string value)
        {
            List<string> valueNames = new List<string>();
            int n;
            bool result = Int32.TryParse(value, out n);
            if (result)
            {
                switch (propertyname)
                {
                    case "ComissionSubType":
                        value = ComissionSubTypes.Find(n).ToString();
                        break;
                    case "Archive":
                        value = Archives.Find(n).ToString();
                        break;
                    case "Client":
                        value = Clients.Find(n).ToString();
                        break;
                    case "ComissionCalculator":
                        value = ComissionCalculator.Find(n).ToString();
                        break;
                    case "Company":
                        value = Companies.Find(n).ToString();
                        break;
                    case "Contact":
                        value = Contacts.Find(n).ToString();
                        break;
                    case "DisabilityInsuranceCompany":
                        value = DisabilityInsuranceCompanies.Find(n).ToString();
                        break;
                    case "DocumentCategory":
                        value = DocumentCategories.Find(n).ToString();
                        break;
                    case "DocumentGroup":
                        value = DocumentGroups.Find(n).ToString();
                        break;
                    case "DocumentType":
                        value = DocumentTypes.Find(n).ToString();
                        break;
                    case "Drug":
                        value = Drugs.Find(n).ToString();
                        break;
                    case "File":
                        value = Files.Find(n).ToString();
                        break;
                    case "FileReview":
                        value = FileReviews.Find(n).ToString();
                        break;
                    case "FileTask":
                        value = FileTasks.Find(n).ToString();
                        break;
                    case "Group":
                        value = Groups.Find(n).ToString();
                        break;
                    case "HearAboutUs":
                        value = HearAboutUs.Find(n).ToString();
                        break;
                    case "Intake":
                        value = Intakes.Find(n).ToString();
                        break;
                    case "Lawyer":
                        value = Lawyers.Find(n).ToString();
                        break;
                    case "MatterSubType":
                        value = MatterSubTypes.Find(n).ToString();
                        break;
                    case "MatterType":
                        value = MatterTypes.Find(n).ToString();
                        break;
                    case "MedicalSummary":
                        value = MedicalSummaries.Find(n).ToString();
                        break;
                    case "MobileCarrier":
                        value = MobileCarriers.Find(n).ToString();
                        break;
                    case "OutOfPocketHealthCareExp":
                        value = OutOfPocketHealthCareExp.Find(n).ToString();
                        break;
                    case "Pharmacy":
                        value = Pharmacies.Find(n).ToString();
                        break;
                    case "Position":
                        value = Positions.Find(n).ToString();
                        break;
                    case "Province":
                        value = Provinces.Find(n).ToString();
                        break;
                    case "StandardBenefitRow":
                        value = StandardBenefitRows.Find(n).ToString();
                        break;
                    case "Task":
                        value = Tasks.Find(n).ToString();
                        break;
                    case "TaskCategory":
                        value = TaskCategories.Find(n).ToString();
                        break;
                    case "TaskState":
                        value = TaskStates.Find(n).ToString();
                        break;
                    case "Template":
                        value = Templates.Find(n).ToString();
                        break;
                    case "UploadArchiveSettings":
                        value = UploadArchivesSettings.Find(n).ToString();
                        break;

                }
                if (value.Contains("\r\n"))
                {
                    value = value.Replace("\r\n", string.Empty);
                }
            }
            return value;
        }

        //Add-Migration Initial_EFCore -Context DataContext -Project RRFFilesManager.DataAccess
        //Update-Database -Context DataContext -Project RRFFilesManager.DataAccess
    }
}
