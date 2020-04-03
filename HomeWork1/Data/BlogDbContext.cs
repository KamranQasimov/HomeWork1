using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HomeWork1.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("SiteDbConnection") { }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        
    }
}