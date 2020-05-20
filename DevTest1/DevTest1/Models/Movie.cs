using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevTest1.Models
{
	public class Movie()
	{
	public string Titulo { get; set; }
    public int Duracion { get; set; }
    public DateTime FechaEstreno { get; set; }
    public bool EstaEnCartelera { get; set; }
	}
}
