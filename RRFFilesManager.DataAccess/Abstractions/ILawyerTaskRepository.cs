using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ILawyerTaskRepository
    {
        void Insert(LawyerTask lawyerTask);
        void Update(LawyerTask lawyerTask);
        void SoftDelete(int lawyerTaskId);
        LawyerTask GetById(int lawyerTaskId);
        IEnumerable<LawyerTask> List();
        void SwitchLawyer(Lawyer formerLawyer, Lawyer newLawyer);
        IEnumerable<LawyerTask> Search(string searchText, Lawyer lawyer, TaskState taskState, int? take = null);
    }
}
