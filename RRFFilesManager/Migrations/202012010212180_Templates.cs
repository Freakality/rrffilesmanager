namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Templates : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CYATemplates", newName: "Templates");
            AddColumn("dbo.Templates", "Category", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Templates", "Category");
            RenameTable(name: "dbo.Templates", newName: "CYATemplates");
        }
    }
}
