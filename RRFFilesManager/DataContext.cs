using System.Data.Entity;
using System;
using System.IO;
using RRFFilesManager.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class DataContext : DbContext
    {
 
        public DataContext() : base("DefaultConnection") {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Province> Provinces { get; set; }
    }
}
