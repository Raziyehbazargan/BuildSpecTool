namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePages : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (1, 'Home', 'Landing' ,'/home')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (2, 'Contact', 'Code Page','/contact')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (3, 'Hotel', 'Code Page', '/hotel')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (4, 'Survey', 'Code Page', '/survey')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (5, 'Session', 'Code Page', '/session')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (6, 'Activity', 'Code Page', '/activities')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (7, 'Edit(Summary)', 'Code Page', '/edit')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (8, 'Create', 'Code Page', 'auth/create')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (9, 'login', 'Code Page', 'auth/login')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (10, 'Associate', 'Code Page', 'auth/associate')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (11, 'Verify', 'Code Page', 'auth/Verifymail')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (12, 'Reset Password', 'Code Page', 'auth/reset')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (13, 'Verify Complete', 'Code Page', 'auth/verifycomplete')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (14, 'Agenda', 'Code Page', '/agenda')");
            Sql("INSERT INTO Pages(Id, Name, Type, Path) VALUES (15, 'FAQ', 'Static Page', '/faq')");
        }
        
        public override void Down()
        {
        }
    }
}
