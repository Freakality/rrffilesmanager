using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Abstractions
{
    public class Intake
    {
        public int ID { get; set; }
        public virtual File File { get; set; }

        public DateTime LiaDate { get; set; }
        public bool LiaMVR { get; set; }
        public bool LiaReportCollision { get; set; }
        public bool LiaMVCExchange { get; set; }
        public bool LiaOtherDoc { get; set; }
        public string LiaWhereAccident { get; set; }
        public string LiaExplain { get; set; }
        public string LiaHavePhotos { get; set; }
        public string LiaEstimDamage { get; set; }
        public string LiaYourFault { get; set; }
        public string LiaDriverName { get; set; }
        public string LiaOwnerName { get; set; }
        public string LiaInsuranceCo { get; set; }
        public string LiaHaveCopy { get; set; }
        public string LiaOwnNegligence { get; set; }
        public string LiaFaultPerson { get; set; }
        public string LiaMunicipality { get; set; }
        public string LiaNotifiedMunicipality { get; set; }
        public string LiaNotes { get; set; }

        public string EILWereEmployed { get; set; }
        public string EILEmployed4Weeks { get; set; }
        public string EILEmployed52Weeks { get; set; }
        public string EILT4Employee { get; set; }
        public string EILT4Company { get; set; }
        public string EILCollecInsurance { get; set; }
        public string EILEmployeeGrossEarning { get; set; }
        public string EILHowLongEmployee { get; set; }
        public string EILJobTitle { get; set; }
        public string EILExplainJob { get; set; }
        public string EILWereSelfEmployed { get; set; }
        public string EILSelfBusinessName { get; set; }
        public string EILSelfGrossEarning { get; set; }
        public string EILHowLongBusiness { get; set; }
        public string EILNotes { get; set; }

        public string DamHitVehicleConcrete { get; set; }
        public string DamHeadInjuries { get; set; }
        public string DamUpperBodyInjuries { get; set; }
        public string DamLowerBodyInjuries { get; set; }
        public string DamPsychologicalEffect { get; set; }
        public string DamPrescribed { get; set; }
        public string DamWereSeeingDoctor { get; set; }
        public string DamPreAccident { get; set; }
        public string DamPreIllness { get; set; }
        public string DamNotes { get; set; }

        public string AccBenDriverPassenger { get; set; }
        public string AccBenWereRegisOwner { get; set; }
        public string AccBenRegisOwnerName { get; set; }
        public string AccBenPolicyNumber { get; set; }
        public string AccBenClaimNumber { get; set; }
        public string AccBenInsuranceCompany { get; set; }
        public string AccBenAdjuster { get; set; }
        public string AccBenOCF1 { get; set; }
        public string AccBenOCF2 { get; set; }
        public string AccBenOCF3 { get; set; }
        public string AccBenReplacBenef { get; set; }
        public string AccBenNotes { get; set; }

        public string Notes { get; set; }

        public string PolSickBenefits { get; set; }
        public string PolWhoPaidBenefits { get; set; }
        public DateTime PolDateLostBenefits { get; set; }
        public string PolDeniedSTPorLTD { get; set; }
        public string PolHowMuchBeingPaid { get; set; }
        public virtual DisabilityInsuranceCompany PolCompanyDeniedBenefits { get; set; }
        public string PolLTDPrivateOrEmployerGroup { get; set; }
        public DateTime PolDateSubmittedLTD { get; set; }
        public DateTime PolDateStartedCollLTD { get; set; }
        public DateTime PolDateLastDayLTD { get; set; }
        public string PolFirstTimeLTDApproved { get; set; }
        public string PolReasonTerminateLTD { get; set; }
        public string PolApplicationForCPP { get; set; }
        public string PolCPPOwnOrCompany { get; set; }
        public string PolCPPApproved { get; set; }
        public string PolOtherNotes { get; set; }
        public bool Hold { get; set; }
        public string ExcelFile { get; set; }
        public string WordFile { get; set; }
    }
}
