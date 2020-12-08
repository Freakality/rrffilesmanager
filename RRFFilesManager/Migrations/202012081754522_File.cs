namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class File : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Intakes", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.Intakes", "FileLawyer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Intakes", "HowHear_ID", "dbo.HearAboutUs");
            DropForeignKey("dbo.Intakes", "MatterSubType_ID", "dbo.MatterSubTypes");
            DropForeignKey("dbo.Intakes", "MatterType_ID", "dbo.MatterTypes");
            DropForeignKey("dbo.Intakes", "ResponsibleLawyer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Intakes", "StaffInterviewer_ID", "dbo.Lawyers");
            DropIndex("dbo.Intakes", new[] { "Client_ID" });
            DropIndex("dbo.Intakes", new[] { "FileLawyer_ID" });
            DropIndex("dbo.Intakes", new[] { "HowHear_ID" });
            DropIndex("dbo.Intakes", new[] { "MatterSubType_ID" });
            DropIndex("dbo.Intakes", new[] { "MatterType_ID" });
            DropIndex("dbo.Intakes", new[] { "ResponsibleLawyer_ID" });
            DropIndex("dbo.Intakes", new[] { "StaffInterviewer_ID" });
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FileNumber = c.Int(nullable: false),
                        DateOfCall = c.DateTime(nullable: false),
                        DateOFLoss = c.DateTime(nullable: false),
                        LimitationPeriod = c.String(),
                        StatutoryNotice = c.String(),
                        AdditionalNotes = c.String(),
                        Client_ID = c.Int(),
                        FileLawyer_ID = c.Int(),
                        HowHear_ID = c.Int(),
                        MatterSubType_ID = c.Int(),
                        MatterType_ID = c.Int(),
                        ResponsibleLawyer_ID = c.Int(),
                        StaffInterviewer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.Client_ID)
                .ForeignKey("dbo.Lawyers", t => t.FileLawyer_ID)
                .ForeignKey("dbo.HearAboutUs", t => t.HowHear_ID)
                .ForeignKey("dbo.MatterSubTypes", t => t.MatterSubType_ID)
                .ForeignKey("dbo.MatterTypes", t => t.MatterType_ID)
                .ForeignKey("dbo.Lawyers", t => t.ResponsibleLawyer_ID)
                .ForeignKey("dbo.Lawyers", t => t.StaffInterviewer_ID)
                .Index(t => t.Client_ID)
                .Index(t => t.FileLawyer_ID)
                .Index(t => t.HowHear_ID)
                .Index(t => t.MatterSubType_ID)
                .Index(t => t.MatterType_ID)
                .Index(t => t.ResponsibleLawyer_ID)
                .Index(t => t.StaffInterviewer_ID);
            
            AddColumn("dbo.Intakes", "File_ID", c => c.Int());
            AlterColumn("dbo.Clients", "Salutation", c => c.String());
            AlterColumn("dbo.Clients", "FirstName", c => c.String());
            AlterColumn("dbo.Clients", "LastName", c => c.String());
            AlterColumn("dbo.Clients", "Address", c => c.String());
            AlterColumn("dbo.Clients", "SuiteApt", c => c.String());
            AlterColumn("dbo.Clients", "Email", c => c.String());
            AlterColumn("dbo.Clients", "PostalCode", c => c.String());
            AlterColumn("dbo.Clients", "City", c => c.String());
            AlterColumn("dbo.Clients", "HomeNumber", c => c.String());
            AlterColumn("dbo.Clients", "WorkNumber", c => c.String());
            AlterColumn("dbo.Clients", "MobileNumber", c => c.String());
            AlterColumn("dbo.Clients", "MobileCarrier", c => c.String());
            AlterColumn("dbo.Clients", "EmailToText", c => c.String());
            AlterColumn("dbo.Clients", "OtherNotes", c => c.String());
            AlterColumn("dbo.Provinces", "Description", c => c.String());
            AlterColumn("dbo.Companies", "Description", c => c.String());
            AlterColumn("dbo.Companies", "Memo", c => c.String());
            AlterColumn("dbo.Companies", "Phone", c => c.String());
            AlterColumn("dbo.Companies", "Email", c => c.String());
            AlterColumn("dbo.Companies", "Street", c => c.String());
            AlterColumn("dbo.Companies", "City", c => c.String());
            AlterColumn("dbo.Companies", "PostalCode", c => c.String());
            AlterColumn("dbo.Contacts", "Salutation", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
            AlterColumn("dbo.Contacts", "MiddleName", c => c.String());
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "Initials", c => c.String());
            AlterColumn("dbo.Contacts", "Prefix", c => c.String());
            AlterColumn("dbo.Contacts", "Suffix", c => c.String());
            AlterColumn("dbo.Contacts", "Memo", c => c.String());
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Street", c => c.String());
            AlterColumn("dbo.Contacts", "City", c => c.String());
            AlterColumn("dbo.Contacts", "PostalCode", c => c.String());
            AlterColumn("dbo.DisabilityInsuranceCompanies", "Description", c => c.String());
            AlterColumn("dbo.HearAboutUs", "Description", c => c.String());
            AlterColumn("dbo.Intakes", "LiaWhereAccident", c => c.String());
            AlterColumn("dbo.Intakes", "LiaExplain", c => c.String());
            AlterColumn("dbo.Intakes", "LiaHavePhotos", c => c.String());
            AlterColumn("dbo.Intakes", "LiaEstimDamage", c => c.String());
            AlterColumn("dbo.Intakes", "LiaYourFault", c => c.String());
            AlterColumn("dbo.Intakes", "LiaDriverName", c => c.String());
            AlterColumn("dbo.Intakes", "LiaOwnerName", c => c.String());
            AlterColumn("dbo.Intakes", "LiaInsuranceCo", c => c.String());
            AlterColumn("dbo.Intakes", "LiaHaveCopy", c => c.String());
            AlterColumn("dbo.Intakes", "LiaOwnNegligence", c => c.String());
            AlterColumn("dbo.Intakes", "LiaFaultPerson", c => c.String());
            AlterColumn("dbo.Intakes", "LiaMunicipality", c => c.String());
            AlterColumn("dbo.Intakes", "LiaNotifiedMunicipality", c => c.String());
            AlterColumn("dbo.Intakes", "LiaNotes", c => c.String());
            AlterColumn("dbo.Intakes", "EILWereEmployed", c => c.String());
            AlterColumn("dbo.Intakes", "EILEmployed4Weeks", c => c.String());
            AlterColumn("dbo.Intakes", "EILEmployed52Weeks", c => c.String());
            AlterColumn("dbo.Intakes", "EILT4Employee", c => c.String());
            AlterColumn("dbo.Intakes", "EILT4Company", c => c.String());
            AlterColumn("dbo.Intakes", "EILCollecInsurance", c => c.String());
            AlterColumn("dbo.Intakes", "EILEmployeeGrossEarning", c => c.String());
            AlterColumn("dbo.Intakes", "EILHowLongEmployee", c => c.String());
            AlterColumn("dbo.Intakes", "EILJobTitle", c => c.String());
            AlterColumn("dbo.Intakes", "EILExplainJob", c => c.String());
            AlterColumn("dbo.Intakes", "EILWereSelfEmployed", c => c.String());
            AlterColumn("dbo.Intakes", "EILSelfBusinessName", c => c.String());
            AlterColumn("dbo.Intakes", "EILSelfGrossEarning", c => c.String());
            AlterColumn("dbo.Intakes", "EILHowLongBusiness", c => c.String());
            AlterColumn("dbo.Intakes", "EILNotes", c => c.String());
            AlterColumn("dbo.Intakes", "DamHitVehicleConcrete", c => c.String());
            AlterColumn("dbo.Intakes", "DamHeadInjuries", c => c.String());
            AlterColumn("dbo.Intakes", "DamUpperBodyInjuries", c => c.String());
            AlterColumn("dbo.Intakes", "DamLowerBodyInjuries", c => c.String());
            AlterColumn("dbo.Intakes", "DamPsychologicalEffect", c => c.String());
            AlterColumn("dbo.Intakes", "DamPrescribed", c => c.String());
            AlterColumn("dbo.Intakes", "DamWereSeeingDoctor", c => c.String());
            AlterColumn("dbo.Intakes", "DamPreAccident", c => c.String());
            AlterColumn("dbo.Intakes", "DamPreIllness", c => c.String());
            AlterColumn("dbo.Intakes", "DamNotes", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenDriverPassenger", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenWereRegisOwner", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenRegisOwnerName", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenPolicyNumber", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenClaimNumber", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenInsuranceCompany", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenAdjuster", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenOCF1", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenOCF2", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenOCF3", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenReplacBenef", c => c.String());
            AlterColumn("dbo.Intakes", "AccBenNotes", c => c.String());
            AlterColumn("dbo.Intakes", "Notes", c => c.String());
            AlterColumn("dbo.Intakes", "PolSickBenefits", c => c.String());
            AlterColumn("dbo.Intakes", "PolWhoPaidBenefits", c => c.String());
            AlterColumn("dbo.Intakes", "PolDeniedSTPorLTD", c => c.String());
            AlterColumn("dbo.Intakes", "PolHowMuchBeingPaid", c => c.String());
            AlterColumn("dbo.Intakes", "PolLTDPrivateOrEmployerGroup", c => c.String());
            AlterColumn("dbo.Intakes", "PolFirstTimeLTDApproved", c => c.String());
            AlterColumn("dbo.Intakes", "PolReasonTerminateLTD", c => c.String());
            AlterColumn("dbo.Intakes", "PolApplicationForCPP", c => c.String());
            AlterColumn("dbo.Intakes", "PolCPPOwnOrCompany", c => c.String());
            AlterColumn("dbo.Intakes", "PolCPPApproved", c => c.String());
            AlterColumn("dbo.Intakes", "PolOtherNotes", c => c.String());
            AlterColumn("dbo.Intakes", "ExcelFile", c => c.String());
            AlterColumn("dbo.Intakes", "WordFile", c => c.String());
            AlterColumn("dbo.Lawyers", "Description", c => c.String());
            AlterColumn("dbo.MatterSubTypes", "Description", c => c.String());
            AlterColumn("dbo.MatterSubTypes", "StatutoryNotice", c => c.String());
            AlterColumn("dbo.MatterTypes", "Description", c => c.String());
            AlterColumn("dbo.MobileCarriers", "Description", c => c.String());
            AlterColumn("dbo.MobileCarriers", "Gate", c => c.String());
            AlterColumn("dbo.Templates", "Category", c => c.String());
            AlterColumn("dbo.Templates", "TypeOfTemplate", c => c.String());
            AlterColumn("dbo.Templates", "TemplateName", c => c.String());
            AlterColumn("dbo.Templates", "TemplatePath", c => c.String());
            CreateIndex("dbo.Intakes", "File_ID");
            AddForeignKey("dbo.Intakes", "File_ID", "dbo.Files", "ID");
            DropColumn("dbo.Intakes", "FileNumber");
            DropColumn("dbo.Intakes", "DateOfCall");
            DropColumn("dbo.Intakes", "DateOFLoss");
            DropColumn("dbo.Intakes", "LimitationPeriod");
            DropColumn("dbo.Intakes", "StatutoryNotice");
            DropColumn("dbo.Intakes", "AdditionalNotes");
            DropColumn("dbo.Intakes", "Client_ID");
            DropColumn("dbo.Intakes", "FileLawyer_ID");
            DropColumn("dbo.Intakes", "HowHear_ID");
            DropColumn("dbo.Intakes", "MatterSubType_ID");
            DropColumn("dbo.Intakes", "MatterType_ID");
            DropColumn("dbo.Intakes", "ResponsibleLawyer_ID");
            DropColumn("dbo.Intakes", "StaffInterviewer_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Intakes", "StaffInterviewer_ID", c => c.Int());
            AddColumn("dbo.Intakes", "ResponsibleLawyer_ID", c => c.Int());
            AddColumn("dbo.Intakes", "MatterType_ID", c => c.Int());
            AddColumn("dbo.Intakes", "MatterSubType_ID", c => c.Int());
            AddColumn("dbo.Intakes", "HowHear_ID", c => c.Int());
            AddColumn("dbo.Intakes", "FileLawyer_ID", c => c.Int());
            AddColumn("dbo.Intakes", "Client_ID", c => c.Int());
            AddColumn("dbo.Intakes", "AdditionalNotes", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "StatutoryNotice", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "LimitationPeriod", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "DateOFLoss", c => c.DateTime(nullable: false));
            AddColumn("dbo.Intakes", "DateOfCall", c => c.DateTime(nullable: false));
            AddColumn("dbo.Intakes", "FileNumber", c => c.Int(nullable: false));
            DropForeignKey("dbo.Intakes", "File_ID", "dbo.Files");
            DropForeignKey("dbo.Files", "StaffInterviewer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Files", "ResponsibleLawyer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Files", "MatterType_ID", "dbo.MatterTypes");
            DropForeignKey("dbo.Files", "MatterSubType_ID", "dbo.MatterSubTypes");
            DropForeignKey("dbo.Files", "HowHear_ID", "dbo.HearAboutUs");
            DropForeignKey("dbo.Files", "FileLawyer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Files", "Client_ID", "dbo.Clients");
            DropIndex("dbo.Intakes", new[] { "File_ID" });
            DropIndex("dbo.Files", new[] { "StaffInterviewer_ID" });
            DropIndex("dbo.Files", new[] { "ResponsibleLawyer_ID" });
            DropIndex("dbo.Files", new[] { "MatterType_ID" });
            DropIndex("dbo.Files", new[] { "MatterSubType_ID" });
            DropIndex("dbo.Files", new[] { "HowHear_ID" });
            DropIndex("dbo.Files", new[] { "FileLawyer_ID" });
            DropIndex("dbo.Files", new[] { "Client_ID" });
            AlterColumn("dbo.Templates", "TemplatePath", c => c.String(unicode: false));
            AlterColumn("dbo.Templates", "TemplateName", c => c.String(unicode: false));
            AlterColumn("dbo.Templates", "TypeOfTemplate", c => c.String(unicode: false));
            AlterColumn("dbo.Templates", "Category", c => c.String(unicode: false));
            AlterColumn("dbo.MobileCarriers", "Gate", c => c.String(unicode: false));
            AlterColumn("dbo.MobileCarriers", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.MatterTypes", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.MatterSubTypes", "StatutoryNotice", c => c.String(unicode: false));
            AlterColumn("dbo.MatterSubTypes", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.Lawyers", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "WordFile", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "ExcelFile", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolOtherNotes", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolCPPApproved", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolCPPOwnOrCompany", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolApplicationForCPP", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolReasonTerminateLTD", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolFirstTimeLTDApproved", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolLTDPrivateOrEmployerGroup", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolHowMuchBeingPaid", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolDeniedSTPorLTD", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolWhoPaidBenefits", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "PolSickBenefits", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "Notes", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenNotes", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenReplacBenef", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenOCF3", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenOCF2", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenOCF1", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenAdjuster", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenInsuranceCompany", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenClaimNumber", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenPolicyNumber", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenRegisOwnerName", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenWereRegisOwner", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "AccBenDriverPassenger", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamNotes", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamPreIllness", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamPreAccident", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamWereSeeingDoctor", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamPrescribed", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamPsychologicalEffect", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamLowerBodyInjuries", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamUpperBodyInjuries", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamHeadInjuries", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "DamHitVehicleConcrete", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILNotes", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILHowLongBusiness", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILSelfGrossEarning", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILSelfBusinessName", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILWereSelfEmployed", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILExplainJob", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILJobTitle", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILHowLongEmployee", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILEmployeeGrossEarning", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILCollecInsurance", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILT4Company", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILT4Employee", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILEmployed52Weeks", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILEmployed4Weeks", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "EILWereEmployed", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaNotes", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaNotifiedMunicipality", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaMunicipality", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaFaultPerson", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaOwnNegligence", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaHaveCopy", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaInsuranceCo", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaOwnerName", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaDriverName", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaYourFault", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaEstimDamage", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaHavePhotos", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaExplain", c => c.String(unicode: false));
            AlterColumn("dbo.Intakes", "LiaWhereAccident", c => c.String(unicode: false));
            AlterColumn("dbo.HearAboutUs", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.DisabilityInsuranceCompanies", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "PostalCode", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "City", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Street", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Memo", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Suffix", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Prefix", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Initials", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "MiddleName", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(unicode: false));
            AlterColumn("dbo.Contacts", "Salutation", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "PostalCode", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "City", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "Street", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "Email", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "Phone", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "Memo", c => c.String(unicode: false));
            AlterColumn("dbo.Companies", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.Provinces", "Description", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "OtherNotes", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "EmailToText", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "MobileCarrier", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "MobileNumber", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "WorkNumber", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "HomeNumber", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "City", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "PostalCode", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "Email", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "SuiteApt", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "Address", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "LastName", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "FirstName", c => c.String(unicode: false));
            AlterColumn("dbo.Clients", "Salutation", c => c.String(unicode: false));
            DropColumn("dbo.Intakes", "File_ID");
            DropTable("dbo.Files");
            CreateIndex("dbo.Intakes", "StaffInterviewer_ID");
            CreateIndex("dbo.Intakes", "ResponsibleLawyer_ID");
            CreateIndex("dbo.Intakes", "MatterType_ID");
            CreateIndex("dbo.Intakes", "MatterSubType_ID");
            CreateIndex("dbo.Intakes", "HowHear_ID");
            CreateIndex("dbo.Intakes", "FileLawyer_ID");
            CreateIndex("dbo.Intakes", "Client_ID");
            AddForeignKey("dbo.Intakes", "StaffInterviewer_ID", "dbo.Lawyers", "ID");
            AddForeignKey("dbo.Intakes", "ResponsibleLawyer_ID", "dbo.Lawyers", "ID");
            AddForeignKey("dbo.Intakes", "MatterType_ID", "dbo.MatterTypes", "ID");
            AddForeignKey("dbo.Intakes", "MatterSubType_ID", "dbo.MatterSubTypes", "ID");
            AddForeignKey("dbo.Intakes", "HowHear_ID", "dbo.HearAboutUs", "ID");
            AddForeignKey("dbo.Intakes", "FileLawyer_ID", "dbo.Lawyers", "ID");
            AddForeignKey("dbo.Intakes", "Client_ID", "dbo.Clients", "ID");
        }
    }
}
