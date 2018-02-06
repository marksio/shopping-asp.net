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

            List<string> id = new List<string>();
            id.Add("1");
            id.Add("2");
            id.Add("3");
            id.Add("4");
            id.Add("5");
            id.Add("6");
            ViewBag.id = id;

            List<string> name = new List<string>();
            name.Add("T-Shirt");
            name.Add("Smartphone");
            name.Add("Laptop");
            name.Add("Milk");
            name.Add("Milo");
            name.Add("Hard Disk");
            ViewBag.name = name;
            ViewBag.itemNum = name.Count;

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

        public ActionResult Cart()
        {
            string valueid=null;
            if (Request.Cookies["id"] != null)
            {
                for(int i = 0; i<Request.Cookies["id"].Value.Length;)
                {
                    string[] arr = new string[Request.Cookies["id"].Value.Length];
                    arr[i] = Request.Cookies["id"].Value.ToString();

                    valueid = arr[i];
                    i++;
                }
                ViewBag.message = valueid;                
            }
            return View();
        }
    }
}
