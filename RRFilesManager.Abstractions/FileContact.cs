using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class FileContact
    {
        public int FileId { get; set; }
        public virtual File File { get; set; }

        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
