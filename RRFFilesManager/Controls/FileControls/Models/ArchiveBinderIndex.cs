using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.FileControls.Models
{
    public class ArchiveBinderIndex : ArchiveBinder
    {

        public ArchiveBinderIndex(Archive archive) : base(archive)
        {
            IndexCategory = archive.DocumentType?.IndexCategory;
        }
        public string IndexCategory { get; set; }
    }
}
