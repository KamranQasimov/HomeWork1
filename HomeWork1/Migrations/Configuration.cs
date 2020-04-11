namespace HomeWork1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HomeWork1.Data.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HomeWork1.Data.BlogDbContext context)
        {
            //context.Menus.AddOrUpdate(new Data.Menu
            //{
            //    Id = 1,
            //    Name = "Home",
            //    IsActive = true,
            //    Order = 1
            //}, new Data.Menu
            //{
            //    Id = 2,
            //    Name = "About",
            //    IsActive = true,
            //    Order = 2
            //}, new Data.Menu 
            //{
            //    Id = 3,
            //    Name = "Resume",
            //    IsActive = true,
            //    Order = 3
            //},new Data.Menu 
            //{
            //    Id = 4,
            //    Name = "Services",
            //    IsActive = true,
            //    Order = 4
            //},new Data.Menu
            //{
            //    Id = 5,
            //    Name = "Skills",
            //    IsActive = true,
            //    Order = 5
            //},new Data.Menu
            //{
            //    Id = 6,
            //    Name = "Projects",
            //    IsActive = true,
            //    Order = 6
            //}, new Data.Menu
            //{
            //    Id = 7,
            //    Name = "Contact",
            //    IsActive = true,
            //    Order = 7
            //});
            //context.Authors.AddOrUpdate(new Data.Author
            //{
            //    Id = 1,
            //    Name = "Kamran",
            //    Surname = "Qasimov",
            //    PhoneNumber = "+994-51-573-72-22",
            //    Address = "Baku, Sallaxani street, 7A",
            //    BirthDate = DateTime.ParseExact("January 07,1996", "MMMM dd,yyyy", CultureInfo.InvariantCulture),
            //    ZipCode = "AZ1000",
            //    Country = "Azerbaijan",
            //    Email = "kamranqasimov390@gmail.com",
            //    CompletedProjects = 1,
            //    CupsOfCoffee = 2,
            //    AwardsAmount = 1,
            //    Work = "Freelance web developer"

            //});
            context.Resumes.AddOrUpdate(new Data.Resume
            {
                Id = 2,
                AuthorId = 1,
                WorkName = "Web developer",
                WorkPlace = "Somewhere",
                WorkStart = DateTime.ParseExact("14.02.2019", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                WorkEnd = DateTime.Now,
                About = "Hello my site's quests. I worked as Web Developer nearly 1 year. I'll be happy if i can help you with problems in Web development."
            });
            //context.Services.AddOrUpdate(new Data.Services
            //{
            //    Id = 1,
            //    AuthorId = 1,
            //    Name = "Web Development",
            //    //Logopath = "pngwawe.png",

            //}, new Data.Services
            //{
            //    Id = 2,
            //    AuthorId = 1,
            //    Name = "App Development",
            //    //Logopath = "pngwawe.png",

            //}
            //);
            context.Skills.AddOrUpdate(new Data.Skill

            {
                Id = 4,
                AuthorId = 1,
                Name = "C#",
                Percent = 70
            }, new Data.Skill
            {
                Id = 5,
                AuthorId = 1,
                Name = "Asp.NET",
                Percent = 40
            });



            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
