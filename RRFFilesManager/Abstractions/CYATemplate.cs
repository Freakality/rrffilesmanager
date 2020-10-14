using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions
{
    public class CYATemplate
    {
        public int ID { get; set; }
        public virtual MatterType MatterType { get; set; }
        public string TypeOfTemplate { get; set; }
        public string TemplateName { get; set; }
        public string TemplatePath { get; set; }

        public override string ToString() => TemplateName;
    }
}
