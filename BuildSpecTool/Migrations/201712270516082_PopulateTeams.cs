namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTeams : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Teams(Id, Name) VALUES (1, 'Cookie Scrumbles')");
            Sql("INSERT INTO Teams(Id, Name) VALUES (2, 'A Team Has No Name')");
            Sql("INSERT INTO Teams(Id, Name) VALUES (3, 'Challenge Accepted')");
            Sql("INSERT INTO Teams(Id, Name) VALUES (4, 'Dragoncore')");
            Sql("INSERT INTO Teams(Id, Name) VALUES (5, 'Periwinkie')");
        }
        
        public override void Down()
        {
        }
    }
}
