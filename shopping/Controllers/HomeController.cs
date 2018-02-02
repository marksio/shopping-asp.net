using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            List<string> title = new List<string>();
            title.Add("T-Shirt");
            title.Add("Smartphone");
            title.Add("Laptop");
            title.Add("Milk");
            title.Add("Milo");
            title.Add("Hard Disk");
            ViewBag.title = title;
            ViewBag.itemNum = title.Count;

            List<string> desc = new List<string>();
            desc.Add("T-Shirt");
            desc.Add("Smartphone");
            desc.Add("Laptop");
            desc.Add("Milk");
            desc.Add("Milo");
            desc.Add("Hard Disk");
            ViewBag.desc = desc;

            List<string> link = new List<string>();
            link.Add("T-Shirt");
            link.Add("Smartphone");
            link.Add("Laptop");
            link.Add("Milk");
            link.Add("Milo");
            link.Add("Hard Disk");
            ViewBag.link = link;

            return View();
        }
    }
}
