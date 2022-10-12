using KisiselWebSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }
        public ActionResult GetHomePage(int Id)
        {
            var value = c.HomePages.Find(Id);
            return View("GetHomePage", value);
        }
        public ActionResult HomePageUpdate(HomePage x)
        {
            var hp = c.HomePages.Find(x.Id);
            hp.Name=x.Name;
            hp.Description=x.Description;
            hp.Title=x.Title;
            hp.Profile=x.Profile;
            hp.Contact=x.Contact;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult IconList()
        {
            var value=c.Icons.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult IconAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IconAdd(Icons i)
        {
            c.Icons.Add(i);
            c.SaveChanges();
            return RedirectToAction("IconList");
        }
        public ActionResult GetIcon(int Id)
        {
            var value = c.Icons.Find(Id);
            return View("GetIcon", value);
        }
        public ActionResult UpdateIcon(Icons i)
        {
            var updateicon=c.Icons.Find(i.Id);
            updateicon.IconName=i.IconName;
            updateicon.link = i.link;
            c.SaveChanges();
            return RedirectToAction("IconList");
        }
        public ActionResult DeleteIcon(int Id)
        {
            var del = c.Icons.Find(Id);
            c.Icons.Remove(del);
            c.SaveChanges();
            return RedirectToAction("IconList");
        }
    }
}