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
        
        public Archive(Abstractions.Archive archive) {
            File = archive.File.FileNumber;
            Name = archive.Name;
            Path = archive.Path;
            Group = archive.DocumentGroup;
            Category = archive.DocumentCategory;
            this.archive = archive;
        }
        
        public int File { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DocumentGroup Group { get; set; }
        public DocumentCategory Category { get; set; }

        public Abstractions.Archive GetArchive() => this.archive;
        
    }
    public class Archive<T> : Archive
    {
        private T originalEntity;
        public Archive(T originalEntity, Abstractions.Archive archive) : base(archive)
        {
            this.originalEntity = originalEntity;
        }
        public T GetOriginalEntity() => originalEntity;
    }
}
