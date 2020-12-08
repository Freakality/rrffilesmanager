using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions
{
    public class Archive
    {
        public int ID { get; set; }
        public File File { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
