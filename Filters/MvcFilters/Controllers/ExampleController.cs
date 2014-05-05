using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFilters.Infrastructure.Filters;

namespace MvcFilters.Controllers {

 [MyException]
public class ExampleController : Controller {

        
    public ActionResult Index() {
        Response.Write("Action method is running: " + DateTime.Now);
        return View();
       
    }

    [OutputCache(Duration = 30)]
    public ActionResult ChildAction() {
        Response.Write("Child action method is running: " + DateTime.Now);
        return View();
    }
    [MyException]
    public ActionResult MyExceptionAttribute(int name)
    {
        return View();
    }
     [CustomActionFilter]
    public ActionResult MyActionFileter()
    {
        return Content("safsaf");
    }
}

}
