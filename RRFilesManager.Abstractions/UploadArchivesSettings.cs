using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class UploadArchivesSettings
    {
        public int ID { get; set; }
        public virtual List<FilePath> InputFolders { get; set; }
        public string OutputFolder { get; set; }
    }
}
