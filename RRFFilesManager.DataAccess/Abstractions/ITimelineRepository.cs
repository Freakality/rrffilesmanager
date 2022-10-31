using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ITimelineRepository
    {
        void Insert(Timeline timeline, File file);
        void Update(Timeline timeline);
        void SoftDelete(int timelineId);
        Timeline GetById(int timelineId);
        IEnumerable<Timeline> List();
        IEnumerable<Timeline> Search(File file, int? take = null);
    }
}
