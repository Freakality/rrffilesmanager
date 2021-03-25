using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class DocumentCategory
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public virtual DocumentGroup DocumentGroup { get; set; }
        public DocumentFormEnum? DocumentForm { get; set; }
        public DocumentNameTypeEnum? DocumentNameType { get; set; }
        public override string ToString() => Description;
    }
}
