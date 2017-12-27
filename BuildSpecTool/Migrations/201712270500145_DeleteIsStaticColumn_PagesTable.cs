namespace BuildSpecTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIsStaticColumn_PagesTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Pages DROP COLUMN IsStatic");
        }
        
        public override void Down()
        {
        }
    }
}
