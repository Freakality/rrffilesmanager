namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Salutation = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        SuiteApt = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        PostalCode = c.String(unicode: false),
                        City = c.String(unicode: false),
                        HomeNumber = c.String(unicode: false),
                        WorkNumber = c.String(unicode: false),
                        MobileNumber = c.String(unicode: false),
                        MobileCarrier = c.String(unicode: false),
                        EmailToText = c.String(unicode: false),
                        OtherNotes = c.String(unicode: false),
                        DateOfBirth = c.DateTime(),
                        Province_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Provinces", t => t.Province_ID)
                .Index(t => t.Province_ID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CYATemplates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeOfTemplate = c.String(unicode: false),
                        TemplateName = c.String(unicode: false),
                        TemplatePath = c.String(unicode: false),
                        MatterType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MatterTypes", t => t.MatterType_ID)
                .Index(t => t.MatterType_ID);
            
            CreateTable(
                "dbo.MatterTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.HearAboutUs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Intakes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FileNumber = c.Int(nullable: false),
                        DateOfCall = c.DateTime(nullable: false),
                        DateOFLoss = c.DateTime(nullable: false),
                        LimitationPeriod = c.String(unicode: false),
                        StatutoryNotice = c.String(unicode: false),
                        AdditionalNotes = c.String(unicode: false),
                        LiaDate = c.DateTime(nullable: false),
                        LiaMVR = c.Boolean(nullable: false),
                        LiaReportCollision = c.Boolean(nullable: false),
                        LiaMVCExchange = c.Boolean(nullable: false),
                        LiaOtherDoc = c.Boolean(nullable: false),
                        LiaWhereAccident = c.String(unicode: false),
                        LiaExplain = c.String(unicode: false),
                        LiaHavePhotos = c.String(unicode: false),
                        LiaEstimDamage = c.String(unicode: false),
                        LiaYourFault = c.String(unicode: false),
                        LiaDriverName = c.String(unicode: false),
                        LiaOwnerName = c.String(unicode: false),
                        LiaInsuranceCo = c.String(unicode: false),
                        LiaHaveCopy = c.String(unicode: false),
                        LiaOwnNegligence = c.String(unicode: false),
                        LiaFaultPerson = c.String(unicode: false),
                        LiaMunicipality = c.String(unicode: false),
                        LiaNotifiedMunicipality = c.String(unicode: false),
                        LiaNotes = c.String(unicode: false),
                        EILWereEmployed = c.String(unicode: false),
                        EILEmployed4Weeks = c.String(unicode: false),
                        EILEmployed52Weeks = c.String(unicode: false),
                        EILT4Employee = c.String(unicode: false),
                        EILT4Company = c.String(unicode: false),
                        EILCollecInsurance = c.String(unicode: false),
                        EILEmployeeGrossEarning = c.String(unicode: false),
                        EILHowLongEmployee = c.String(unicode: false),
                        EILJobTitle = c.String(unicode: false),
                        EILExplainJob = c.String(unicode: false),
                        EILWereSelfEmployed = c.String(unicode: false),
                        EILSelfBusinessName = c.String(unicode: false),
                        EILSelfGrossEarning = c.String(unicode: false),
                        EILHowLongBusiness = c.String(unicode: false),
                        EILNotes = c.String(unicode: false),
                        DamHitVehicleConcrete = c.String(unicode: false),
                        DamHeadInjuries = c.String(unicode: false),
                        DamUpperBodyInjuries = c.String(unicode: false),
                        DamLowerBodyInjuries = c.String(unicode: false),
                        DamPsychologicalEffect = c.String(unicode: false),
                        DamPrescribed = c.String(unicode: false),
                        DamWereSeeingDoctor = c.String(unicode: false),
                        DamPreAccident = c.String(unicode: false),
                        DamPreIllness = c.String(unicode: false),
                        DamNotes = c.String(unicode: false),
                        AccBenDriverPassenger = c.String(unicode: false),
                        AccBenWereRegisOwner = c.String(unicode: false),
                        AccBenRegisOwnerName = c.String(unicode: false),
                        AccBenPolicyNumber = c.String(unicode: false),
                        AccBenClaimNumber = c.String(unicode: false),
                        AccBenInsuranceCompany = c.String(unicode: false),
                        AccBenAdjuster = c.String(unicode: false),
                        AccBenOCF1 = c.String(unicode: false),
                        AccBenOCF2 = c.String(unicode: false),
                        AccBenOCF3 = c.String(unicode: false),
                        AccBenReplacBenef = c.String(unicode: false),
                        AccBenNotes = c.String(unicode: false),
                        Notes = c.String(unicode: false),
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
            
            CreateTable(
                "dbo.Lawyers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                        NumberID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MatterSubTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                        StatutoryNotice = c.String(unicode: false),
                        MatterType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.MatterTypes", t => t.MatterType_ID)
                .Index(t => t.MatterType_ID);
            
            CreateTable(
                "dbo.MobileCarriers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                        Gate = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Intakes", "StaffInterviewer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Intakes", "ResponsibleLawyer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Intakes", "MatterType_ID", "dbo.MatterTypes");
            DropForeignKey("dbo.Intakes", "MatterSubType_ID", "dbo.MatterSubTypes");
            DropForeignKey("dbo.MatterSubTypes", "MatterType_ID", "dbo.MatterTypes");
            DropForeignKey("dbo.Intakes", "HowHear_ID", "dbo.HearAboutUs");
            DropForeignKey("dbo.Intakes", "FileLawyer_ID", "dbo.Lawyers");
            DropForeignKey("dbo.Intakes", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.CYATemplates", "MatterType_ID", "dbo.MatterTypes");
            DropForeignKey("dbo.Clients", "Province_ID", "dbo.Provinces");
            DropIndex("dbo.MatterSubTypes", new[] { "MatterType_ID" });
            DropIndex("dbo.Intakes", new[] { "StaffInterviewer_ID" });
            DropIndex("dbo.Intakes", new[] { "ResponsibleLawyer_ID" });
            DropIndex("dbo.Intakes", new[] { "MatterType_ID" });
            DropIndex("dbo.Intakes", new[] { "MatterSubType_ID" });
            DropIndex("dbo.Intakes", new[] { "HowHear_ID" });
            DropIndex("dbo.Intakes", new[] { "FileLawyer_ID" });
            DropIndex("dbo.Intakes", new[] { "Client_ID" });
            DropIndex("dbo.CYATemplates", new[] { "MatterType_ID" });
            DropIndex("dbo.Clients", new[] { "Province_ID" });
            DropTable("dbo.MobileCarriers");
            DropTable("dbo.MatterSubTypes");
            DropTable("dbo.Lawyers");
            DropTable("dbo.Intakes");
            DropTable("dbo.HearAboutUs");
            DropTable("dbo.MatterTypes");
            DropTable("dbo.CYATemplates");
            DropTable("dbo.Provinces");
            DropTable("dbo.Clients");
        }
    }
}
