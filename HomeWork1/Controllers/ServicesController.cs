using HomeWork1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Resume
        private readonly BlogDbContext _blogDbContext;
        public ServicesController()
        {
            _blogDbContext = new BlogDbContext();
        }
        public PartialViewResult AllServices()
        {
            var services = _blogDbContext.Services.ToList();
            return PartialView(services);
        }
    }
}