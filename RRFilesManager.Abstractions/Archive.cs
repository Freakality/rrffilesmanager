using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Archive
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? TemplateId { get; set; }
        public virtual Template Template { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
