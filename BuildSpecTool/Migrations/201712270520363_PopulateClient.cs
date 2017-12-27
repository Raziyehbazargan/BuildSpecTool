namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClient : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clients(Name) VALUES ('Microsoft')");
            Sql("INSERT INTO Clients(Name) VALUES ('Zillow')");
            Sql("INSERT INTO Clients(Name) VALUES ('Redhat')");
        }
        
        public override void Down()
        {
        }
    }
}
