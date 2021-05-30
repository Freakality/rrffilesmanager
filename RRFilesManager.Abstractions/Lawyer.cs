using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class Lawyer
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int? NumberID { get; set; }
        public DateTime? ContractDate { get; set; }
        public bool? EarnBaseCommissionAsFileLawyer { get; set; }
        public double? ResponsibleLawyerBaseCommissionMultiplier { get; set; }
        public bool IsParalegal { get; set; }
        public override string ToString() => Description;
    }
}
