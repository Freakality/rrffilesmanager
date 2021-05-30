using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;

namespace RRFFilesManager.DataAccess
{
    public class ComissionCalculatorRepository : IComissionCalculatorRepository
    {
        private readonly DataContext _context;
        public ComissionCalculatorRepository(DataContext context)
        {
            _context = context;
        }

        public  ComissionCalculator GetById(int comissionCalculatorId)
        {
            var item = _context.ComissionCalculator.FirstOrDefault(x => x.ID == comissionCalculatorId);
            return item;
        }
        public ComissionCalculator Get(File file, string comissionSubType, string contractTerm, bool deductibleAchieved)
        {
            var item = _context.ComissionCalculator.FirstOrDefault(s => s.MatterType == file.MatterType &&
                                                                    s.ComissionSubType == comissionSubType &&
                                                                    s.FileLawyer == file.FileLawyer &&
                                                                    s.ResponsibleLawyer == file.ResponsibleLawyer &&
                                                                    s.ContractTerm == contractTerm &&
                                                                    s.DeductibleAchieved == deductibleAchieved
                                                                );
            if(item == null)
                item = _context.ComissionCalculator.FirstOrDefault(s => s.MatterType == file.MatterType &&
                                                        s.ComissionSubType == comissionSubType &&
                                                        s.FileLawyer == file.FileLawyer &&
                                                        s.ResponsibleLawyer == null &&
                                                        s.ContractTerm == contractTerm &&
                                                        s.DeductibleAchieved == deductibleAchieved
                                                    );
            return item;
        }

        public void Insert(ComissionCalculator comissionCalculator)
        {
            _context.ComissionCalculator.Add(comissionCalculator);
            _context.SaveChanges();
        }

        public  IEnumerable<ComissionCalculator> List()
        {
            return _context.ComissionCalculator.ToList(); ;
        }

        public void SoftDelete(int comissionCalculatorId)
        {
            var itemToDelete = GetById(comissionCalculatorId);
            _context.SaveChanges();
        }

        public void Delete(ComissionCalculator comissionCalculator)
        {
            var trxComissionCalculator = GetById(comissionCalculator.ID);
            _context.ComissionCalculator.Remove(trxComissionCalculator);
            _context.SaveChanges();
        }

        public void Update(ComissionCalculator comissionCalculator)
        {
            var trxComissionCalculator = GetById(comissionCalculator.ID);
            _context.Entry(trxComissionCalculator).CurrentValues.SetValues(comissionCalculator);
            _context.SaveChanges();
        }
        
    }
}
