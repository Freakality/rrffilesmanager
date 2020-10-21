namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntakeFiles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Intakes", "ExcelFile", c => c.String(unicode: false));
            AddColumn("dbo.Intakes", "WordFile", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Intakes", "WordFile");
            DropColumn("dbo.Intakes", "ExcelFile");
        }
    }
}
