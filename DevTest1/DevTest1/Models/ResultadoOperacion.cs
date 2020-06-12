using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace DevTest1.Models
{
    public enum ResultadoOperacion
    {
        Aprobado = 1,
        Reprobado = 2,
       [Description ("Pendiente de Asignar")] PendienteDeAsignar = 3
    }
}