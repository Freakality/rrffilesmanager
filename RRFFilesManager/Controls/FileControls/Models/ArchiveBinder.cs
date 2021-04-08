using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.FileControls.Models
{
    public class ArchiveBinder
    {
        private Archive archive;
        public ArchiveBinder(Archive archive)
        {
            ID = archive.ID;
            Type = archive.DocumentType;
            Date = archive.Created;
            Name = archive.Name;
            this.archive = archive;
        }
        public bool Check { get; set; }
        public int ID { get; set; }
        public DocumentType Type { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public Archive GetArchive() => this.archive;
    }
}
