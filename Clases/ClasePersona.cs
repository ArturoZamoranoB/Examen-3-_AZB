using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3__AZB.Clases
{
    internal class ClasePersona
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set;}

            public Persona(string nombre, int edad) 
            {
                Nombre = nombre;
                Edad = edad;
            }
        }
    }
}
