namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DisabilityInsuranceCompany : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DisabilityInsuranceCompanies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Intakes", "PolCompanyDeniedBenefits_ID", c => c.Int());
            CreateIndex("dbo.Intakes", "PolCompanyDeniedBenefits_ID");
            AddForeignKey("dbo.Intakes", "PolCompanyDeniedBenefits_ID", "dbo.DisabilityInsuranceCompanies", "ID");
            DropColumn("dbo.Intakes", "PolCompanyDeniedBenefits");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Intakes", "PolCompanyDeniedBenefits", c => c.String(unicode: false));
            DropForeignKey("dbo.Intakes", "PolCompanyDeniedBenefits_ID", "dbo.DisabilityInsuranceCompanies");
            DropIndex("dbo.Intakes", new[] { "PolCompanyDeniedBenefits_ID" });
            DropColumn("dbo.Intakes", "PolCompanyDeniedBenefits_ID");
            DropTable("dbo.DisabilityInsuranceCompanies");
        }
    }
}
