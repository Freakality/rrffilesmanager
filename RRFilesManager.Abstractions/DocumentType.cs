using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class DocumentType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual DocumentCategory DocumentCategory { get; set; }
        public DocumentFormEnum DocumentForm { get; set; }
        public DocumentNameTypeEnum DocumentNameType { get; set; }
        public string IndexCategory { get; set; }
        public override string ToString() => Description;
    }
}
