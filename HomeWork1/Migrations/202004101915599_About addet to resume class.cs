namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aboutaddettoresumeclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resumes", "About", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resumes", "About");
        }
    }
}
