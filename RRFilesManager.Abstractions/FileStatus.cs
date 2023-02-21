using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class FileStatus
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public override string ToString() => Description;
    }

    public enum FileStatusEnum
    {
        PotentialFile = 1,
        OpenFile = 2,
        ClosedFile = 3,
        NotRetained = 4,
    }
}
