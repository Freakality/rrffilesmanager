namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Company : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Memo", c => c.String(unicode: false));
            AddColumn("dbo.Companies", "Phone", c => c.String(unicode: false));
            AddColumn("dbo.Companies", "Email", c => c.String(unicode: false));
            AddColumn("dbo.Companies", "Street", c => c.String(unicode: false));
            AddColumn("dbo.Companies", "City", c => c.String(unicode: false));
            AddColumn("dbo.Companies", "PostalCode", c => c.String(unicode: false));
            AddColumn("dbo.Companies", "Province_ID", c => c.Int());
            CreateIndex("dbo.Companies", "Province_ID");
            AddForeignKey("dbo.Companies", "Province_ID", "dbo.Provinces", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Companies", "Province_ID", "dbo.Provinces");
            DropIndex("dbo.Companies", new[] { "Province_ID" });
            DropColumn("dbo.Companies", "Province_ID");
            DropColumn("dbo.Companies", "PostalCode");
            DropColumn("dbo.Companies", "City");
            DropColumn("dbo.Companies", "Street");
            DropColumn("dbo.Companies", "Email");
            DropColumn("dbo.Companies", "Phone");
            DropColumn("dbo.Companies", "Memo");
        }
    }
}
