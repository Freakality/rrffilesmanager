using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class IntakeManager
    {
        private static readonly IIntakeRepository _intakeRepository;
        private static readonly IFileRepository _fileRepository;
        static IntakeManager()
        {
            _intakeRepository = (IIntakeRepository)Program.ServiceProvider.GetService(typeof(IIntakeRepository));
            _fileRepository = (IFileRepository)Program.ServiceProvider.GetService(typeof(IFileRepository));
        }

        public static int GetNewFileNumber(Lawyer lawyer)
        {
            if (lawyer == null)
                return 999999999;
            var lastFileNumber = _fileRepository.GetLastFile()?.FileNumber;
            if(lastFileNumber == null)
                return int.Parse($"{DateTime.Now.Year}{lawyer.Number?.ToString() ?? ""}001");
            var lastNumber = int.Parse(lastFileNumber.ToString()?.Substring(6, 3));
            var newNumber = (lastNumber + 1).ToString().PadLeft(3, '0');
            return int.Parse($"{DateTime.Now.Year}{lawyer.Number?.ToString() ?? ""}{newNumber}");
        }
        public static string GetFilePath(string fileName)
        {
            if (fileName == null)
                return null;
            return Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], fileName);
        }

        public static void SetHoldIntake(Intake intake, bool hold)
        {
            intake.Hold = hold;
            _intakeRepository.Update(intake);
        }
    }
}
