using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.ArchiveControls.Models
{
    public class Archive
    {
        public Archive(Abstractions.Archive archive) {
            File = archive.File.FileNumber;
            Name = archive.Name;
            Path = archive.Path;
            Group = archive.DocumentFolder;
            Category = archive.DocumentCategory;
        }
        public int File { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Group { get; set; }
        public string Category { get; set; }
    }
}
