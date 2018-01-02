namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEventMailModel1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.EventMails", "EventId");
            AddForeignKey("dbo.EventMails", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventMails", "EventId", "dbo.Events");
            DropIndex("dbo.EventMails", new[] { "EventId" });
        }
    }
}
