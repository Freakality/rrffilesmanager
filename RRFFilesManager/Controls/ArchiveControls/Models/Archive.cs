using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.ArchiveControls.Models
{
    public class Archive
    {
        private Abstractions.Archive archive;
        private Abstractions.OutOfPocketHealthCareExp outOfPocketHealthCareExp;
        public Archive(Abstractions.Archive archive) {
            File = archive.File.FileNumber;
            Name = archive.Name;
            Path = archive.Path;
            Group = archive.DocumentGroup;
            Category = archive.DocumentCategory;
            this.archive = archive;
        }
        public Archive(OutOfPocketHealthCareExp outOfPocketHealthCareExp) : this(outOfPocketHealthCareExp.Archive)
        {
            this.outOfPocketHealthCareExp = outOfPocketHealthCareExp;
        }
        public int File { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DocumentGroup Group { get; set; }
        public DocumentCategory Category { get; set; }

        public Abstractions.Archive GetArchive() => this.archive;
        public OutOfPocketHealthCareExp GetOutOfPocketHealthCareExp() => this.outOfPocketHealthCareExp;
    }
}
