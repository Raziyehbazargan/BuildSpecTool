namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEventModel : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Events", "TeamId");
            CreateIndex("dbo.Events", "ClientId");
            AddForeignKey("dbo.Events", "ClientId", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "TeamId", "dbo.Teams", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Events", "ClientId", "dbo.Clients");
            DropIndex("dbo.Events", new[] { "ClientId" });
            DropIndex("dbo.Events", new[] { "TeamId" });
        }
    }
}
