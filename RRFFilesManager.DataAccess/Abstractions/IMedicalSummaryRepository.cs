using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IMedicalSummaryRepository
    {
        void Insert(MedicalSummary medicalSummary);
        void Update(MedicalSummary medicalSummary);
        MedicalSummary GetById(int medicalSummaryId);
        IEnumerable<MedicalSummary> List();
        IEnumerable<MedicalSummary> Search(string searchText, int? take = null);
        void Delete(MedicalSummary medicalSummary);
    }
}
