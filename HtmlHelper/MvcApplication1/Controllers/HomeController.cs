using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DropdownListSample()
        {
            List<Region> regionsData = new List<Region> { 
    new Region { RegionID = 7, RegionName = "Northern" }, 
    new Region { RegionID = 3, RegionName = "Central" }, 
    new Region { RegionID = 5, RegionName = "Southern" }, 
};
            
            ViewData["region"] = new SelectList(regionsData,  // items 
                                                   "RegionID",   // dataValueField 
                                                   "RegionName", // dataTextField 
                                                   3);           // selectedValue 
            SelectList lis = new SelectList(regionsData, "RegionID", "RegionName", 3);
            ViewBag.ss = lis;
            return View();
        }


        public ActionResult InlineHelper()
        {

            ViewBag.Days = new[] { "Monday", "Tuesday", "Wednesday", "etc" };
            ViewBag.Fruits = new[] { "Apples", "Mango", "Banana" };

            return View();
        }
        public ActionResult UrlsSample()
        {
            return View();
        }

    }
}
