using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class File
    {
        public int ID { get; set; }
        public virtual Contact Client { get; set; }
        public int FileNumber { get; set; }
        public virtual MatterType MatterType { get; set; }
        public DateTime DateOfCall { get; set; }
        public DateTime DateOFLoss { get; set; }
        public virtual Lawyer StaffInterviewer { get; set; }
        public virtual HearAboutUs HowHear { get; set; }
        public virtual Lawyer FileLawyer { get; set; }
        public virtual Lawyer ResponsibleLawyer { get; set; }
        public virtual MatterSubType MatterSubType { get; set; }
        public virtual ComissionSubType SubTypeCategory { get; set; }
        public string LimitationPeriod { get; set; }
        public string StatutoryNotice { get; set; }
        public string AdditionalNotes { get; set; }

        public virtual Intake Intake { get; set; }
        public virtual Timeline Timeline { get; set; }
        public virtual FileStatus PreviousStatus { get; set; }
        public virtual FileStatus CurrentStatus { get; set; }
        public DateTime DateOfStatusChange { get; set; }
        public virtual ICollection<Archive> Archives { get; set; }
        public virtual ICollection<FileContact> Peoples { get; set; }
        public virtual ICollection<OutOfPocketHealthCareExp> Prescriptions { get; set; }
        public virtual ICollection<FileReview> Reviews { get; set; }
        public virtual ICollection<FileTask> Tasks { get; set; }
        public virtual ICollection<ClientNote> ClientNotes { get; set; }

        public override string ToString() => $"{FileNumber} - {Client?.FirstName} {Client?.LastName}";
    }
}
