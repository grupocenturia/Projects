using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenturiaWeb.Controllers
{
    public class CenturiaController : Controller
    {
        // GET: Centuria


        public ActionResult Login(string User)
        {
            if (User == "Ruben")
            {
                return View("Menu");
            }

            else
            {
                return View();
            }
        }
        [Authorize]
        public ActionResult Menu()
        {
            return View();
        }
    }
}