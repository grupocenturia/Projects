using DevTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.ComponentModel;

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
                FechaNacimiento = new DateTime(1988, 11, 01)
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
            ViewBag.listado = ObtenerMiListado();
            return View();
        }

        public List<SelectListItem> ObtenerMiListado()
        {
            return new List<SelectListItem>()
                {
                    new SelectListItem()
                    {
                        Text = "Si",
                        Value = "1"
                    },

                      new SelectListItem()
                    {
                        Text = "No",
                        Value = "2"
                    },

                        new SelectListItem()
                    {
                        Text = "Quizas",
                        Value = "3",
                        Disabled = true
                    }

                };
        }

        public class Persona
        {
            public string Nombre { get; set; }
            public bool Trabaja { get; set; }
            public DateTime FechaNacimiento { get; set; }
        }

        public ActionResult DropDownList()
        {
            ViewBag.MiListadoEnum = ToListSelectListItem<ResultadoOperacion>();
            return View();
        }
        private List<SelectListItem> ToListSelectListItem<T>()
        {
            var t = typeof(T);
            if (!t.IsEnum)
            {
                throw new ApplicationException("Tipo debe ser Enum");
            }

            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);
            var result = new List<SelectListItem>();

            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var Descripcion = member.Name;

                if (attributeDescription.Any())
                {
                    Descripcion = ((DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                result.Add(new SelectListItem()
                {
                    Text = Descripcion,
                    Value = valor.ToString()
                });

            }
            return result;
        }


            }
    }
