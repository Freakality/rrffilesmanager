using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class LogItem
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        public override string ToString() => $"{Date.ToString("MMM - dd - yyyy")} - {Lawyer}: {Description}";
    }
}
