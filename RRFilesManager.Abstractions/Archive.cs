using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Archive
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? TemplateId { get; set; }
        public virtual Template Template { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

        public string DocumentFolder { get; set; }
        public string DocumentCategory { get; set; }
        public string DocumentType { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime DateRangeFrom { get; set; }
        public DateTime DateRangeTo { get; set; }

        public string PolicyClaimLimit { get; set; }
        public DateTime StatementPeriodFrom { get; set; }
        public DateTime StatementPeriodTo { get; set; }
        public string MRACPaidToDate { get; set; }
        public string MRACRemaining { get; set; }
        public string ACPaidToDate { get; set; }
        public string ACRemaining { get; set; }
        public string MRPaidToDate { get; set; }
        public string MRRemaining { get; set; }
        public string HHPaidToDate { get; set; }
        public string IEAssessPdToDate { get; set; }

        public string Sender { get; set; }
        public string Recipient { get; set; }

        public string AdditionalInfo { get; set; }

        public string BenefitType { get; set; }

        public string PreparedBy { get; set; }

        public string FacilityName { get; set; }
        public string HealthcarePractitioner { get; set; }
        public string TypeOfAssessment { get; set; }
        public string TreatmentAmount { get; set; }

    }
}
