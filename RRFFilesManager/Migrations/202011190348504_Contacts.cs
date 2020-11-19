namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contacts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Salutation = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        MiddleName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Initials = c.String(unicode: false),
                        Prefix = c.String(unicode: false),
                        Suffix = c.String(unicode: false),
                        Memo = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Street = c.String(unicode: false),
                        City = c.String(unicode: false),
                        PostalCode = c.String(unicode: false),
                        Company_ID = c.Int(),
                        Province_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.Company_ID)
                .ForeignKey("dbo.Provinces", t => t.Province_ID)
                .Index(t => t.Company_ID)
                .Index(t => t.Province_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "Province_ID", "dbo.Provinces");
            DropForeignKey("dbo.Contacts", "Company_ID", "dbo.Companies");
            DropIndex("dbo.Contacts", new[] { "Province_ID" });
            DropIndex("dbo.Contacts", new[] { "Company_ID" });
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
        }
    }
}
