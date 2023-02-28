using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IPolicyParticularsRepository
    {
        void Insert(PolicyParticulars policyParticulars, File file);
        void Update(PolicyParticulars policyParticulars);
        void SoftDelete(int policyParticularsId);
        PolicyParticulars GetById(int policyParticularsId);
        IEnumerable<PolicyParticulars> List();
        IEnumerable<PolicyParticulars> Search(File file, int? take = null);
    }
}
