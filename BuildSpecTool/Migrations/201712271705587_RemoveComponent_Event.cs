namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveComponent_Event : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EventComponent_Id", "dbo.EventComponents");
            DropIndex("dbo.Events", new[] { "EventComponent_Id" });
            DropColumn("dbo.Events", "EventComponent_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventComponent_Id", c => c.Int());
            CreateIndex("dbo.Events", "EventComponent_Id");
            AddForeignKey("dbo.Events", "EventComponent_Id", "dbo.EventComponents", "Id");
        }
    }
}
