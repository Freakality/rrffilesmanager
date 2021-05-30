using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class ComissionCalculator
    {
        public int ID { get; set; }
        public virtual MatterType MatterType { get; set; }
        public string ComissionSubType { get; set; }
        public virtual Lawyer FileLawyer { get; set; }
        public virtual Lawyer ResponsibleLawyer { get; set; }
        public virtual string ContractTerm { get; set; }
        public virtual bool DeductibleAchieved { get; set; }
        public virtual double? FLBaseComissionMultiplier { get; set; }
        public virtual double? RLBaseComissionMultiplier { get; set; }
        public virtual double? RPBaseComissionMultiplier { get; set; }
        public virtual double? RLDeductibleAchievedx1d5Multiplier { get; set; }
        public virtual double? RLDeductibleAchievedx2Multiplier { get; set; }
        public virtual double? RPDeductibleAchievedx1d5Multiplier { get; set; }
        public virtual double? RPDeductibleAchievedx2Multiplier { get; set; }
        public virtual double? MatterProceededToTrialMultiplier { get; set; }
        public virtual double? RLMatterProceededToABHearingMultiplier { get; set; }
        public virtual double? RPMatterProceededToABHearingMultiplier { get; set; }
    }
}
