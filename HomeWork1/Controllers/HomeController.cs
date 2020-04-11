using HomeWork1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class HomeController : Controller
    {
        private readonly BlogDbContext _blogDbContext;
        public HomeController()
        {
            _blogDbContext = new BlogDbContext();     
        }
        // GET: Home
        [ActionName("Index")]
        public async Task<ActionResult> IndexAsync()
        {
            var Author = await _blogDbContext.Authors.Where(x => x.Id == 1).FirstOrDefaultAsync();
            return View(Author);
        }
    }
}