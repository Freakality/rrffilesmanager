using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class DenialBenefit
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public override string ToString() => Description;
    }
}
