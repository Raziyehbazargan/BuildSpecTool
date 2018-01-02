namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeventPageModel : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.EventPages", "EventId");
            AddForeignKey("dbo.EventPages", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventPages", "EventId", "dbo.Events");
            DropIndex("dbo.EventPages", new[] { "EventId" });
        }
    }
}
