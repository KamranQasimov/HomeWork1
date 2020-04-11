using HomeWork1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class ResumesController : Controller
    {
        // GET: Resume
        private readonly BlogDbContext _blogDbContext;
        public ResumesController()
        {
            _blogDbContext = new BlogDbContext();
        }
        public PartialViewResult AllResumes()
        {
            var resumes = _blogDbContext.Resumes.Where(x=>x.Id ==6).ToList();
            return PartialView(resumes);
        }
    }
}
