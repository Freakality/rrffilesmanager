using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDrugRepository
    {
        void Insert(Drug drug);
        void Update(Drug drug);
        void SoftDelete(int drugId);
        void Delete(Drug drug);
        Drug GetById(int drugId);
        IEnumerable<Drug> List();
        IEnumerable<Drug> Search(string searchText, int? take = null);
    }
}
