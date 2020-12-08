using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenturiaWeb.Controllers
{ 
    public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";

        return View();
    }

    public ActionResult Menu()
    {
        ViewBag.Message = "Your application description page.";

        return View();
    }

    public ActionResult Administrator()
    {
        ViewBag.Message = "Administrator";

        return View();
    }

    public ActionResult Language()
    {
        ViewBag.Message = "Language";

        return View();
    }

    public ActionResult Profile()
    {    
        ViewBag.Message = "Perfil";
       
        return View();
    }

    [HttpPost]
    public ActionResult Contact(string User)
    {
        ViewBag.Message = "Your contact page." + User;

        return View();
    }

}
}