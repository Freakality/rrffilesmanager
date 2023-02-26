using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IABOverviewRepository
    {
        void Insert(ABOverview abOverview, File file);
        void Update(ABOverview abOverview);
        void SoftDelete(int abOverviewId);
        ABOverview GetById(int abOverviewId);
        IEnumerable<ABOverview> List();
        IEnumerable<ABOverview> Search(File file, int? take = null);
    }
}
