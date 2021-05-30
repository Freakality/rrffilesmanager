using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IComissionCalculatorRepository
    {
        void Insert(ComissionCalculator comissionCalculator);
        void Update(ComissionCalculator comissionCalculator);
        void SoftDelete(int comissionCalculatorId);
        void Delete(ComissionCalculator comissionCalculator);
        ComissionCalculator GetById(int comissionCalculatorId);
        ComissionCalculator Get(File file, string comissionSubType, string contractTerm, bool deductibleAchieved);
        IEnumerable<ComissionCalculator> List();
    }
}
