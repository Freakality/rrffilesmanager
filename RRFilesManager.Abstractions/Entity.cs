using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Entity
    {
        public int ID { get; set; }
        public override string ToString() => $"{ID}";
    }
}
