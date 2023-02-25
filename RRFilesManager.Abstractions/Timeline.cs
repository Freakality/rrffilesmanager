using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class Timeline
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }
        public DateTime LiabilityMeetingDate { get; set; }
        public DateTime ProposedDateIssueSOC { get; set; }
        public DateTime PrePleadingsMeetingDate { get; set; }
        public DateTime ActualDateSOCIssued { get; set; }
        public DateTime ProposedDateToServeSOC { get; set; }
        public DateTime ActualDateSOCServed { get; set; }
        public DateTime PlaintiffAODSent { get; set; }
        public DateTime MedicalSummariesPreDiscDueDate { get; set; }
        public DateTime PreDiscoveryMeetingDate { get; set; }
        public DateTime DefendantAODRequest { get; set; }
        public DateTime DateOfPlaintiffDiscovery { get; set; }
        public DateTime DateOfDefendantDiscovery { get; set; }
        public DateTime DatePlaintiffUndertakingComplete { get; set; }
        public DateTime AllDefendantUndertakingRecd { get; set; }
        public DateTime PreMedSttleMeetingDate { get; set; }
        public DateTime MemoToBeServedDate { get; set; }
        public DateTime MediationResolutionDate { get; set; }
        public DateTime DateToFileTrialRecordBy { get; set; }
        public DateTime DateTrialRecordFiled { get; set; }
        public DateTime PrePreTrialMeetingDate { get; set; }
        public DateTime PreTrialToBeServedDate { get; set; }
        public DateTime PreTrialResolutionDate { get; set; }
        public DateTime TrialDate { get; set; }

    }
}
