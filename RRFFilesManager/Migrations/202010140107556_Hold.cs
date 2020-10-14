namespace RRFFilesManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hold : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Intakes", "Hold", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Intakes", "Hold");
        }
    }
}
