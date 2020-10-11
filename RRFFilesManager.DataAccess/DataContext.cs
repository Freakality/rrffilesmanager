using RRFFilesManager.Abstractions;
using System;
using System.Data.Entity;

namespace RRFFilesManager.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(string nameOrConnectionString): base(nameOrConnectionString) { }
        public DbSet<Client> Clients { get; set; }

        public DbSet<Province> Provinces { get; set; }
    }
}
