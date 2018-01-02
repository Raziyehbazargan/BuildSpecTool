namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEventAttendeeTypeModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventAttendeeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        AttendeeTypeId = c.Byte(nullable: false),
                        Invited = c.Boolean(nullable: false),
                        HasRSVP = c.Boolean(nullable: false),
                        Capacity = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AttendeeTypes", t => t.AttendeeTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.AttendeeTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventAttendeeTypes", "EventId", "dbo.Events");
            DropForeignKey("dbo.EventAttendeeTypes", "AttendeeTypeId", "dbo.AttendeeTypes");
            DropIndex("dbo.EventAttendeeTypes", new[] { "AttendeeTypeId" });
            DropIndex("dbo.EventAttendeeTypes", new[] { "EventId" });
            DropTable("dbo.EventAttendeeTypes");
        }
    }
}
