using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ICompanyRepository
    {
        void Insert(Company company);
        void Update(Company company);
        void SoftDelete(int companyId);
        Company GetById(int companyId);
        IEnumerable<Company> List();
    }
}
