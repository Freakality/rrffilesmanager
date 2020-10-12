namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CYATemplates : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CYATemplates", "MatterType_ID", "dbo.MatterTypes");
            DropIndex("dbo.CYATemplates", new[] { "MatterType_ID" });
            DropTable("dbo.CYATemplates");
        }
    }
}
