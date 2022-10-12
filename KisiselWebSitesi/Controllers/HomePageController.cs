using KisiselWebSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }
        public PartialViewResult Icons()
        {
            var value = c.Icons.ToList();
            return PartialView(value);
        }
    }
}