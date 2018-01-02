namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMail : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Mails(Id, Name) VALUES (1, 'Registration Confirmation')");
            Sql("INSERT INTO Mails(Id, Name) VALUES (2, 'Registration Cancellation')");
            Sql("INSERT INTO Mails(Id, Name) VALUES (3, 'Password Reset')");
            Sql("INSERT INTO Mails(Id, Name) VALUES (4, 'Email Verification')");
            Sql("INSERT INTO Mails(Id, Name) VALUES (5, 'Hotel Confirmation')");
            Sql("INSERT INTO Mails(Id, Name) VALUES (6, 'Registration Approved')");
            Sql("INSERT INTO Mails(Id, Name) VALUES (7, 'Registration Declined')");
        }
        
        public override void Down()
        {
        }
    }
}
