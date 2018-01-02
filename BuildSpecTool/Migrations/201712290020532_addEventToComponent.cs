namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEventToComponent : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EventComponents", newName: "Components");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Components", newName: "EventComponents");
        }
    }
}
