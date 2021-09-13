using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class MedicalSummary
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }
        public virtual Archive Archive { get; set; }
        public virtual DocumentGroup DocumentGroup { get; set; }
        public virtual DocumentCategory DocumentCategory { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public DateTime DocumentDate { get; set; }
        public string DocumentSummary { get; set; }
        public string ClientPostalCode { get; set; }
        public string TreatmentCentrePostalCode { get; set; }
        public virtual double? DistanceKilometres { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
