using DevTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevTest1.Models
{
	public List<Movie> ObtenerPelicula()
	{
        var pelicula1 = new Movie();
        {
            Titulo = "Anabel";
            Duracion = 45;
            FechaEstreno = new DateTime(2005, 03, 03);
            EstaEnCartelera = true;
        };

        var pelicula2 = new Movie();
        {
            Titulo = "Rocky 1";
            Duracion = 120;
            FechaEstreno = new DateTime(1998, 03, 03);
            EstaEnCartelera = false;
        };

        var pelicula3 = new Movie();
        {
            Titulo = "Elite";
            Duracion = 100;
            FechaEstreno = new DateTime(2020, 03, 03);
            EstaEnCartelera = true;
        };
        return new List<Movie> { pelicula1, pelicula2, pelicula3 };
    }
}
