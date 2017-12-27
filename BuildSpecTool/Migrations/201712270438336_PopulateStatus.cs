namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status(Id, Name) VALUES (1, 'Approved')");
            Sql("INSERT INTO Status(Id, Name) VALUES (2, 'Cancelled')");
            Sql("INSERT INTO Status(Id, Name) VALUES (3, 'Declined')");
            Sql("INSERT INTO Status(Id, Name) VALUES (4, 'Deleted')");
            Sql("INSERT INTO Status(Id, Name) VALUES (5, 'Incomplete')");
            Sql("INSERT INTO Status(Id, Name) VALUES (6, 'New')");
            Sql("INSERT INTO Status(Id, Name) VALUES (7, 'Pending')");
            Sql("INSERT INTO Status(Id, Name) VALUES (8, 'Registered')");
            Sql("INSERT INTO Status(Id, Name) VALUES (9, 'Waiting List')");
        }
        
        public override void Down()
        {
        }
    }
}
