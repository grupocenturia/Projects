﻿using DevTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Pruebas 123";

            var movie = new MovieService();
            var model = movie.MovieService();
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message ="Prueba.";

            return View();
        }
    }
}