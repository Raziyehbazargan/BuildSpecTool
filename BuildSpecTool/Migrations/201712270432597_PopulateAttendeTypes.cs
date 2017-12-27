namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAttendeTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AttendeeTypes(Id, Name) VALUES (1, 'General Attendee')");
        }
        
        public override void Down()
        {
        }
    }
}
