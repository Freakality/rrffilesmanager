using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Permission
    {
        public int ID { get; set; }
        public string ButtonDescription { get; set; }
        public int MinClearance { get; set; }
        public override string ToString() => ButtonDescription + ": " + MinClearance;
    }
}
