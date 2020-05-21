using DevTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevTest1.Controllers
{
    public class MovieService
    {
        public List<Movie> ObtenerPelicula()
        {
            var pelicula1 = new Movie()
            {
                Titulo = "Elite",
                Duracion = 45,
                FechaEstreno = new DateTime(2020, 03, 03),
                EstaEnCartelera = true,
            };

            var pelicula2 = new Movie()
            {
                Titulo = "Casa de papel",
                Duracion = 55,
                FechaEstreno = new DateTime(2020, 05, 03),
                EstaEnCartelera = true,
            };

            var pelicula3 = new Movie()
            {
                Titulo = "Juegos Macabros",
                Duracion = 120,
                FechaEstreno = new DateTime(2000, 05, 03),
                EstaEnCartelera = false,
            };
            return new List<Movie> { pelicula1, pelicula2, pelicula3 };
        }
    }
}