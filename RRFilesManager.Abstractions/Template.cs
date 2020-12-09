using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class Template
    {
        public int ID { get; set; }
        public virtual MatterType MatterType { get; set; }
        public string Category { get; set; }
        public string TypeOfTemplate { get; set; }
        public string TemplateName { get; set; }
        public string TemplatePath { get; set; }

        public override string ToString() => TemplateName;
    }
}
