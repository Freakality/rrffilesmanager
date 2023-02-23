using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Denial
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }
        public virtual DenialBenefit DenialBenefit { get; set; }
        public decimal AmountInDispute { get; set; }
        public DateTime TreatmentPlanDate { get; set; }
        public DateTime DateDenied { get; set; }
        public string ServiceProvider { get; set; }
        public string ServiceType { get; set; }
        public string RangeFrom { get; set; }
        public string RangeTo { get; set; }
        public string DisputeRelatedTo { get; set; }
        public DateTime LimitationDate { get; set; }
        public virtual DenialStatus DenialStatus { get; set; }
        public string DenialNotes { get; set; }
    }
}
