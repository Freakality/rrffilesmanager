using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Drug
    {
        public int ID { get; set; }
        public string DIN { get; set; }
        public string Name { get; set; }
        public string Schedule { get; set; }
        public string ActiveIngredients { get; set; }
        public string Strength { get; set; }

        public override string ToString() => $"({DIN}) - {Name}";
    }
}
