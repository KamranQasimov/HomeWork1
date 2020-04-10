namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomechangesinAuthorclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "ZipCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.Authors", "PhoneNumber", c => c.Int(nullable: false));
        }
    }
}
