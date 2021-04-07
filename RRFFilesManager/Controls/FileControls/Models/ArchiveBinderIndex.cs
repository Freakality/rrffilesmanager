using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.FileControls.Models
{
    public class ArchiveBinderIndex
    {
        private Archive archive;
        public ArchiveBinderIndex(Archive archive)
        {
            ID = archive.ID;
            Type = archive.DocumentType;
            Date = archive.Created;
            Name = archive.Name;
            IndexCategory = archive.DocumentType?.IndexCategory;
            this.archive = archive;
        }
        public bool Check { get; set; }
        public int ID { get; set; }
        public DocumentType Type { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string IndexCategory { get; set; }

        public Abstractions.Archive GetArchive() => this.archive;
    }
}
