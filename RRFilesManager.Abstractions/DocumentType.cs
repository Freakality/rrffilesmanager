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
        public virtual DocumentFolder DocumentFolder { get; set; }
        public override string ToString() => Description;
    }
}
