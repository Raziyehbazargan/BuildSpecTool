namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Main_Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventComponents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        InvitationUpload = c.Boolean(nullable: false),
                        DynamicAgenda = c.Boolean(nullable: false),
                        RSVPCodes = c.Boolean(nullable: false),
                        Session = c.Boolean(nullable: false),
                        HasHotel = c.Boolean(nullable: false),
                        ApprovalTool = c.Boolean(nullable: false),
                        OnsiteTool = c.Boolean(nullable: false),
                        OverallEvals = c.Boolean(nullable: false),
                        SessionEvals = c.Boolean(nullable: false),
                        Search_Engine = c.Boolean(nullable: false),
                        SpeakerInformation = c.Boolean(nullable: false),
                        AgendaFilter = c.Boolean(nullable: false),
                        AgendaSessionsSignup = c.Boolean(nullable: false),
                        Progress_bar = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsMicrosoftEvent = c.Boolean(nullable: false),
                        IsMicrosoftInternal = c.Boolean(nullable: false),
                        URL = c.String(),
                        Alias = c.String(),
                        EstimatedAttendance = c.Int(nullable: false),
                        Registration_Lead = c.String(),
                        Technical_Lead = c.String(),
                        TimeFormat = c.String(),
                        DateFormat = c.String(),
                        Actual_EventDate = c.DateTime(nullable: false),
                        Live_EventDate = c.DateTime(nullable: false),
                        BuildDueDate = c.DateTime(nullable: false),
                        ClientReviewDueDate = c.DateTime(nullable: false),
                        ClientEditDueDate = c.DateTime(nullable: false),
                        Phone = c.String(),
                        TeamId = c.Byte(nullable: false),
                        ClientId = c.Int(nullable: false),
                        EventComponent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventComponents", t => t.EventComponent_Id)
                .Index(t => t.EventComponent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventComponent_Id", "dbo.EventComponents");
            DropIndex("dbo.Events", new[] { "EventComponent_Id" });
            DropTable("dbo.Events");
            DropTable("dbo.EventComponents");
        }
    }
}
