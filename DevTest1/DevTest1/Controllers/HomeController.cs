using DevTest1.Models;
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
            var persona = new Persona()
            {
                Nombre = "Rubén",
                Trabaja = true,
                FechaNacimiento = new DateTime(1988,11,01)
            };

            ViewBag.Other = persona;
            return View();
        }

        public ActionResult About()
        {
            var movie = new MovieService();
            var model = movie.ObtenerPelicula();
            ViewBag.Message = "Pruebas";

      
            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message ="Prueba.";

            return View();
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public bool Trabaja { get; set; }
            public DateTime FechaNacimiento { get; set; }
        }

         public ActionResult DropDownList()
        {
            ViewBag.Message ="Prueba.";

            return View();
        }
    }
}