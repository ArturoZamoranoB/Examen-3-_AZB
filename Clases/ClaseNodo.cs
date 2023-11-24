using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen_3__AZB.Clases.ClasePersona;

namespace Examen_3__AZB.Clases
{
    internal class ClaseNodo
    {
        public class Nodo
        {
            public Persona Datos { get; set; }
            public Nodo  Siguiente { get; set; }

            public Nodo(Persona persona) 
            {
                Datos = persona;
                Siguiente = null;
            }
        }
    }
}
