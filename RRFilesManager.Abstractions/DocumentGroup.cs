using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class DocumentGroup
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public override string ToString() => Description;
    }
}
