using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ILogItemRepository
    {
        void Insert(LogItem logItem);
        void Update(LogItem logItem);
        void SoftDelete(int logItemId);
        LogItem GetById(int logItemId);
        IEnumerable<LogItem> List();
        IEnumerable<LogItem> Search(string searchText, DateTime dateLimit1, DateTime dateLimit2, int? take = null);
    }
}
