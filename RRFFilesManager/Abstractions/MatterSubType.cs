using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions
{
    public class MatterSubType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public MatterType MatterType { get; set; }
        public string StatutoryNotice { get; set; }
    }
}
