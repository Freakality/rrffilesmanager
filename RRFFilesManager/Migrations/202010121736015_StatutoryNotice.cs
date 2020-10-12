namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StatutoryNotice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Intakes", "StatutoryNotice", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Intakes", "StatutoryNotice");
        }
    }
}
