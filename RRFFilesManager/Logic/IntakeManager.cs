using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Logic
{
    public class IntakeManager
    {
        public static int GetNewFileNumber(Lawyer lawyer)
        {
            if (lawyer == null)
                return 999999999;
            var lastFileNumber = Program.DBContext.Intakes.OrderByDescending(s => s.ID).FirstOrDefault()?.FileNumber;
            if(lastFileNumber == null)
                return int.Parse($"{DateTime.Now.Year}{lawyer.NumberID?.ToString() ?? ""}001");
            var lastNumber = int.Parse(lastFileNumber.ToString()?.Substring(6, 3));
            var newNumber = (lastNumber + 1).ToString().PadLeft(3, '0');
            return int.Parse($"{DateTime.Now.Year}{lawyer.NumberID?.ToString() ?? ""}{newNumber}");
        }
    }
}
