using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.FileControls.Models
{
    public class ArchiveBinder
    {
        private Archive archive;
        public ArchiveBinder(Archive archive)
        {
            ID = archive.ID;
            Type = archive.DocumentType;
            Date = archive.Created;
            Name = archive.Name;
            var amount = 0.00;
            /*foreach(StandardBenefitRow row in archive.StandardBenefitRows)
            {
                amount += row.Amount;
            }*/
            if (archive != null)
            {
                if (!string.IsNullOrWhiteSpace(RegRep(archive.MRACPaidToDate)))
                    amount += Convert.ToDouble(archive.MRACPaidToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.ACPaidToDate)))
                    amount += Convert.ToDouble(archive.ACPaidToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.MRPaidToDate)))
                    amount += Convert.ToDouble(archive.MRPaidToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.HHPaidToDate)))
                    amount += Convert.ToDouble(archive.HHPaidToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.IRBPaidToDate)))
                    amount += Convert.ToDouble(archive.IRBPaidToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.NonEarnerPdToDate)))
                    amount += Convert.ToDouble(archive.NonEarnerPdToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.CGPaidToDate)))
                    amount += Convert.ToDouble(archive.CGPaidToDate.Replace("$", String.Empty));
                if (!string.IsNullOrWhiteSpace(RegRep(archive.IEAssessPdToDate)))
                    amount += Convert.ToDouble(archive.IEAssessPdToDate.Replace("$", String.Empty));

            }
            Amount = Convert.ToDecimal(amount).ToString("C0");
            this.archive = archive;
        }
        public bool Check { get; set; }
        public int ID { get; set; }
        public DocumentType Type { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }

        public Archive GetArchive() => this.archive;
        private string RegRep(string s)
        {
            if (s != null)
            {
                var result = Regex.Replace(s, "[^0-9.]", "");
                if (result == null)
                    return "";
                return result;

            }
            return "";
        }
    }
}
