namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAnnotationsToEventModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Name", c => c.String());
        }
    }
}
