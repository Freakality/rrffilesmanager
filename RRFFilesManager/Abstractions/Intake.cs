using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions
{
    public class Intake
    {
        public string ID { get; set; }
        public int FileNumber { get; set; }
        public Client Client { get; set; }
        public MatterType MatterType { get; set; }
        public DateTime DateOfCall { get; set; }
        public DateTime DateOFLoss { get; set; }
        public Lawyer StaffInterviewer { get; set; }
        public HearAboutUs HowHear { get; set; }
        public Lawyer FileLawyer { get; set; }
        public Lawyer ResponsibleLawyer { get; set; }
        public MatterSubType MatterSubType { get; set; }
        public string LimitationPeriod { get; set; }
        public string StatutoryNotice { get; set; }
        public string AdditionalNotes { get; set; }

    }
}
