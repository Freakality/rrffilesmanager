using System;

namespace RRFFilesManager.Abstractions
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString() =>  $"{Name}";
    }
}
