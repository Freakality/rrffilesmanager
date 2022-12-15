using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class LawyerTask
    {
        public int ID { get; set; }
        public virtual Task Task { get; set; }
        public int TaskId { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        public int LawyerId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DeferUntilDate { get; set; }
        public DateTime TaskStartedDate { get; set; }
        public DateTime WorkedOnDate1 { get; set; }
        public DateTime WorkedOnDate2 { get; set; }
        public DateTime WorkedOnDate3 { get; set; }
        public DateTime NotifiedRRFDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public virtual TaskState State { get; set; }
        public virtual Lawyer AddedBy { get; set; }
        public string Notes { get; set; }
        public override string ToString() => $"{Lawyer.Description} - {Task.Description}";
    }
}
