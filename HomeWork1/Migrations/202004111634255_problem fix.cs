namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class problemfix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "Logopath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Logopath", c => c.String());
        }
    }
}
