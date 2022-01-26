using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class FileReview
    {
        public int ID { get; set; }
        public virtual File File { get; set; }
        public DateTime FRDate { get; set; }
        
        public Byte FRActionABenefitsStatus { get; set; }

        public string FRLiabilityIssues { get; set; }

        public string FRCausationIssues { get; set; }

        public string FRDamagesIssues { get; set; }

        public string FRFileProgressionConsiderations { get; set; }

        public DateTime FRProjectedSettlementDate { get; set; }

        public string FRProjectedSettlementValue { get; set; }

        public string FRProjectedDisbursements { get; set; }

        public string FRCurrentDisbursements { get; set; }

        public string FRProjectedFees { get; set; }

        public string FRProjectedProfitMargin { get; set; }

        public string FROtherNotes { get; set; }

    }
}
