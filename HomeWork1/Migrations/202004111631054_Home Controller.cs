namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HomeController : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Logopath", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Services", "Logopath", c => c.String(nullable: false));
        }
    }
}
