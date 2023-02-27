using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class PolicyParticulars
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }

        public DateTime TermOfPolicyFrom { get; set; }
        public DateTime TermOfPolicyTo { get; set; }

        public string OPCF44R { get; set; }
        public decimal OPCF44RLiabilityLimits { get; set; }

        public string UmbrellaViaAuto { get; set; }
        public decimal UmbrellaViaAutoLiabilityLimits { get; set; }

        public string OptionalBenefitsPurchased { get; set; }
        public string OptionalBenefitsPurchasedDetails { get; set; }

        public virtual DisabilityInsuranceCompany ExcessHomeInsurer { get; set; }
        public string ExcessUmbrellaCoverage { get; set; }
        public string ExcessCopyOfPolicyInFile { get; set; }
        public decimal ExcessCoverageAmount { get; set; }

        public override string ToString() => $"{File.DateOFLoss.ToString("MMMM dd, yyyy")} {File.Intake.AccBenInsuranceCompany}";
    }
}
