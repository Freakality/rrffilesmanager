using System;
using System.Collections.Generic;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class LATData
    {
        public int ID { get; set; }
        public int FileId { get; set; }
        public virtual File File { get; set; }
        public int LATNumber { get; set; }
        public DateTime LATActualDateFiled { get; set; }
        public string LATTribunalNumber { get; set; }
        public DateTime LATCaseConfDate { get; set; }
        public string LATCaseAdjudicator { get; set; }
        public string LATAdjuster { get; set; }
        public string LATInsurer { get; set; }
        public string LATInsurerCounsel { get; set; }
        public string LATInsurerFirm { get; set; }
        public string LATHearingType { get; set; }
        public DateTime LATHearingDate { get; set; }
        public string LATHearingAdjudicator { get; set; }
        public DateTime LATDateSettled { get; set; }
        public double LATAmountSettled { get; set; }
        public string LATIssue1 { get; set; }
        public string LATIssue2 { get; set; }
        public string LATIssue3 { get; set; }
        public string LATIssue4 { get; set; }
        public string LATIssue5 { get; set; }
        public string LATIssue6 { get; set; }
        public string LATIssue7 { get; set; }
        public DateTime LATDueDateToDiscussPotentialLAT { get; set; }
        public DateTime LATDateMetWithLawyerReDenial { get; set; }
        public DateTime LATProposedDateToFileLAT { get; set; }
        public DateTime LATActualDateLATServedOnInsurer { get; set; }
        public DateTime LATInsurersResponseReceived { get; set; }
        public DateTime LATDeadlineToServeFileCaseConfSummary { get; set; }
        public DateTime LATDeadlineToDeliverProductionstoABCounsel { get; set; }
        public DateTime LATDeadlineToReceiveABProductions { get; set; }
        public DateTime LATDeadlineToFileAffidavitReportsEtc { get; set; }
        public DateTime LATDeadlineToReceiveAffidavitReportsEtc { get; set; }
        public DateTime LATDeadlineToFileHearingSubmissionsAndOrBriefs { get; set; }
        public DateTime LATDeadlineToReceiveInsurerSubmissions { get; set; }
        public DateTime LATDeadlineForReplySubmissionsOfTheApplicant { get; set; }
    }
}
