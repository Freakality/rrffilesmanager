using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IOutOfPocketHealthCareExpRepository
    {
        void Insert(OutOfPocketHealthCareExp outOfPocketHealthCareExp);
        void Update(OutOfPocketHealthCareExp outOfPocketHealthCareExp);
        void SoftDelete(int outOfPocketHealthCareExpId);
        OutOfPocketHealthCareExp GetById(int outOfPocketHealthCareExpId);
        IEnumerable<OutOfPocketHealthCareExp> List();
        IEnumerable<OutOfPocketHealthCareExp> Search(string searchText, int? take = null);
    }
}
