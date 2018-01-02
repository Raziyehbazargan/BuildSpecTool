namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEventMailModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventMails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MailId = c.Byte(nullable: false),
                        EventId = c.Int(nullable: false),
                        IsBlast = c.Boolean(nullable: false),
                        Subject = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventMails");
        }
    }
}
