using HomeWork1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class SkillsController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public SkillsController()
        {
            _blogDbContext = new BlogDbContext();
        }
        public PartialViewResult AllSkills()
        {
            var skills = _blogDbContext.Skills.ToList();
            return PartialView(skills);
        }
    }
}