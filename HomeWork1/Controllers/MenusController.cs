using HomeWork1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork1.Controllers
{
    public class MenusController : Controller
    {
        // GET: Menus
        private readonly BlogDbContext _blogDbContext;
        public MenusController()
        {
            _blogDbContext = new BlogDbContext();
        }
        public PartialViewResult AllMenus()
        {
            var menus = _blogDbContext.Menus.Where(x => x.IsActive == true).ToList();
            return PartialView(menus);
        }
    }
}