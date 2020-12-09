using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class File
    {
        public int ID { get; set; }
        public int FileNumber { get; set; }
        public virtual MatterType MatterType { get; set; }
        public DateTime DateOfCall { get; set; }
        public DateTime DateOFLoss { get; set; }
        public virtual Lawyer StaffInterviewer { get; set; }
        public virtual HearAboutUs HowHear { get; set; }
        public virtual Lawyer FileLawyer { get; set; }
        public virtual Lawyer ResponsibleLawyer { get; set; }
        public virtual MatterSubType MatterSubType { get; set; }
        public string LimitationPeriod { get; set; }
        public string StatutoryNotice { get; set; }
        public string AdditionalNotes { get; set; }

        public virtual Client Client { get; set; }
        //public virtual Intake Intake { get; set; }

        public override string ToString() => $"{FileNumber} - {Client.FirstName} {Client.LastName}";
    }
}
