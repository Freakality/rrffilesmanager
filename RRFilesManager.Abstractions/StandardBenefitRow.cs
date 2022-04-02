using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class StandardBenefitRow
    {
        public int ID { get; set; }
        public int ArchiveId { get; set; }
        public virtual Archive Archive { get; set; }
        public int RowNumber { get; set; }
        public string Payee { get; set; }
        public string MRGSAProvided { get; set; }
        public DateTime DatePaid { get; set; }
        public double Amount { get; set; }
        public double IEAmount { get; set; }
        public override string ToString() => $"{RowNumber} - {Payee} {DatePaid.ToShortDateString()}";
    }
}
