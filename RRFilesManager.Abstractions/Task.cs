using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Task
    {
        public int ID { get; set; }
        public string TaskIDNumber { get; set; }
        public string Description { get; set; }
        public int DueBy { get; set; }
        public int DeferBy { get; set; }
        public virtual Lawyer Lawyer { get; set; }
        public bool LockDueDate { get; set; }
        public bool IsMasterTask { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }
        public virtual Lawyer CreatedBy { get; set; }
        public virtual ICollection<TaskDependency> Dependencies { get; set; }
        public override string ToString() => Description;
    }
}
