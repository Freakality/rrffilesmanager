using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class TaskDependency
    {
        public int TaskId { get; set; }
        public virtual Task Task { get; set; }

        public int DependencyId { get; set; }
        public virtual Task Dependency { get; set; }
    }
}
