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
                        ID = c.String(nullable: false, maxLength: 128, unicode: false),
                        FileNumber = c.Int(nullable: false),
                        DateOfCall = c.DateTime(nullable: false),
                        DateOFLoss = c.DateTime(nullable: false),
                        LimitationPeriod = c.String(unicode: false),
                        AdditionalNotes = c.String(unicode: false),
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
                "dbo.MatterTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
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
            DropForeignKey("dbo.Clients", "Province_ID", "dbo.Provinces");
            DropIndex("dbo.MatterSubTypes", new[] { "MatterType_ID" });
            DropIndex("dbo.Intakes", new[] { "StaffInterviewer_ID" });
            DropIndex("dbo.Intakes", new[] { "ResponsibleLawyer_ID" });
            DropIndex("dbo.Intakes", new[] { "MatterType_ID" });
            DropIndex("dbo.Intakes", new[] { "MatterSubType_ID" });
            DropIndex("dbo.Intakes", new[] { "HowHear_ID" });
            DropIndex("dbo.Intakes", new[] { "FileLawyer_ID" });
            DropIndex("dbo.Intakes", new[] { "Client_ID" });
            DropIndex("dbo.Clients", new[] { "Province_ID" });
            DropTable("dbo.MobileCarriers");
            DropTable("dbo.MatterTypes");
            DropTable("dbo.MatterSubTypes");
            DropTable("dbo.Lawyers");
            DropTable("dbo.Intakes");
            DropTable("dbo.HearAboutUs");
            DropTable("dbo.Provinces");
            DropTable("dbo.Clients");
        }
    }
}
