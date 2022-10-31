using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class FileTask
    {
        public int ID { get; set; }
        public virtual Task Task { get; set; }
        public int TaskId { get; set; }
        public virtual File File { get; set; }
        public int FileId { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DeferUntilDate { get; set; }
        public DateTime TaskStartedDate { get; set; }
        public DateTime WorkedOnDate1 { get; set; }
        public DateTime WorkedOnDate2 { get; set; }
        public DateTime WorkedOnDate3 { get; set; }
        public DateTime NotifiedRRFDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public virtual TaskState State { get; set; }
        public string Notes { get; set; }
        public override string ToString() => $"{File.FileNumber} - {File.Client?.FirstName} {File.Client?.LastName} - {Task.Description}";
    }
}
