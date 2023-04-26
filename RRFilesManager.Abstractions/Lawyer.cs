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
        public int? Number { get; set; }
        public DateTime? ContractDate { get; set; }
        public bool? EarnBaseCommissionAsFileLawyer { get; set; }
        public double? ResponsibleLawyerBaseCommissionMultiplier { get; set; }
        public bool IsParalegal { get; set; }
        public string eMailAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int ClearanceLevel { get; set; }
        public bool? FileLawyer { get; set; }
        public bool? ResponsibleLawyer { get; set; }
        public virtual ICollection<LawyerTask> Tasks { get; set; }
        public override string ToString() => Description;
    }
}
