﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenturiaWeb.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator

        public ActionResult Administrator()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Language()
        {
            return View();
        }
    }
}