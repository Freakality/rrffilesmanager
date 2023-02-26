using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class ABOverview
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public string PolicyPreJune1st2016 { get; set; }
        public string PolicyOptionalBenefits { get; set; }
        public string PolicyABCounsel { get; set; }

        public string IncomeBenefitsApplied { get; set; }
        public string IncomeBenefitsType { get; set; }
        public DateTime IncomeBenefitsLatestOCF3 { get; set; }
        public decimal IncomeBenefitsWeeklyAmount { get; set; }
        public string IncomeBenefitsDenied { get; set; }
        public string IncomeBenefitsFiledForLAT { get; set; }

        public string MedicalRehabBenefitsCurrentLevel { get; set; }
        public DateTime MedicalRehabBenefitsEnd { get; set; }
        public decimal MedicalRehabBenefitsAmountPaidToDate { get; set; }

        public string CollateralsInsured { get; set; }
        public string CollateralsFamily { get; set; }

        public string AttendantCareBenefitsInitiallyApproved { get; set; }
        public decimal AttendantCareBenefitsInitialAmount { get; set; }
        public string AttendantCareBenefitsACBeingIncurred { get; set; }
        public string AttendantCareBenefitsWhosFunding { get; set; }
        public DateTime AttendantCareBenefitsLatestForm1 { get; set; }
        public decimal AttendantCareBenefitsAmountPaidToDate { get; set; }

        public string PotentialOffSetsGovtOntario { get; set; }
        public string PotentialOffSetsGovtFederal { get; set; }
        public string PotentialOffSetsGroupPrivate { get; set; }

        public string PotentialCATApplied { get; set; }
        public string PotentialCATCriteria { get; set; }
        public string PotentialCATIEsScheduled { get; set; }
        public string PotentialCATResult { get; set; }
        public string PotentialCATLATFiled { get; set; }

        public DateTime StatementBenefitsStatementDate { get; set; }

        public override string ToString() => $"{LastUpdatedDate}";
    }
}
