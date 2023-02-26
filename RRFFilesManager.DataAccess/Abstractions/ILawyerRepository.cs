using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ILawyerRepository
    {
        void Insert(Lawyer lawyer);
        void Update(Lawyer lawyer);
        void SoftDelete(int lawyerId);
        Lawyer GetById(int lawyerId);
        IEnumerable<Lawyer> List(bool? isParalegal = null);
        Lawyer GetByUserName(string userName);
        Lawyer GetByName(string searchText);
        Lawyer GetByDescription(string searchText);
    }
}
