namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nameaddedtoSkill : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "Name");
        }
    }
}
