namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        BirthDate = c.DateTime(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        CompletedProjects = c.Int(nullable: false),
                        CupsOfCoffee = c.Int(nullable: false),
                        AwardsAmount = c.Int(nullable: false),
                        Work = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Category = c.String(nullable: false),
                        ImagePath = c.String(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Logopath = c.String(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Percent = c.Byte(nullable: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Order = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkName = c.String(nullable: false),
                        WorkPlace = c.String(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        WorkStart = c.DateTime(nullable: false),
                        WorkEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resumes", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Skills", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Services", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Projects", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Resumes", new[] { "AuthorId" });
            DropIndex("dbo.Skills", new[] { "AuthorId" });
            DropIndex("dbo.Services", new[] { "AuthorId" });
            DropIndex("dbo.Projects", new[] { "AuthorId" });
            DropTable("dbo.Resumes");
            DropTable("dbo.Menus");
            DropTable("dbo.Skills");
            DropTable("dbo.Services");
            DropTable("dbo.Projects");
            DropTable("dbo.Authors");
        }
    }
}
