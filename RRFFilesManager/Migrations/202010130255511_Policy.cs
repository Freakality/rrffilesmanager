namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Policy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Intakes", "PolSickBenefits", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolWhoPaidBenefits", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolDateLostBenefits", c => c.DateTime(nullable: false));
            AddColumn("dbo.Intakes", "PolDeniedSTPorLTD", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolHowMuchBeingPaid", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolCompanyDeniedBenefits", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolLTDPrivateOrEmployerGroup", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolDateSubmittedLTD", c => c.DateTime(nullable: false));
            AddColumn("dbo.Intakes", "PolDateStartedCollLTD", c => c.DateTime(nullable: false));
            AddColumn("dbo.Intakes", "PolDateLastDayLTD", c => c.DateTime(nullable: false));
            AddColumn("dbo.Intakes", "PolFirstTimeLTDApproved", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolReasonTerminateLTD", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolApplicationForCPP", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolCPPOwnOrCompany", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolCPPApproved", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "PolOtherNotes", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Intakes", "PolOtherNotes");
            DropColumn("dbo.Intakes", "PolCPPApproved");
            DropColumn("dbo.Intakes", "PolCPPOwnOrCompany");
            DropColumn("dbo.Intakes", "PolApplicationForCPP");
            DropColumn("dbo.Intakes", "PolReasonTerminateLTD");
            DropColumn("dbo.Intakes", "PolFirstTimeLTDApproved");
            DropColumn("dbo.Intakes", "PolDateLastDayLTD");
            DropColumn("dbo.Intakes", "PolDateStartedCollLTD");
            DropColumn("dbo.Intakes", "PolDateSubmittedLTD");
            DropColumn("dbo.Intakes", "PolLTDPrivateOrEmployerGroup");
            DropColumn("dbo.Intakes", "PolCompanyDeniedBenefits");
            DropColumn("dbo.Intakes", "PolHowMuchBeingPaid");
            DropColumn("dbo.Intakes", "PolDeniedSTPorLTD");
            DropColumn("dbo.Intakes", "PolDateLostBenefits");
            DropColumn("dbo.Intakes", "PolWhoPaidBenefits");
            DropColumn("dbo.Intakes", "PolSickBenefits");
        }
    }
}
