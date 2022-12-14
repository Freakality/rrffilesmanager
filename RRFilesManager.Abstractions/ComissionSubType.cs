using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class ComissionSubType : Entity
    {
        public virtual MatterType MatterType { get; set; }
        public string Description { get; set; }
        public double ProjectedSettlementDays { get; set; }
        public double ContigencyFee { get; set; }
        public double ProjectedDisbursementsAmount { get; set; }
        public override string ToString() => $"{Description}";
    }
}
