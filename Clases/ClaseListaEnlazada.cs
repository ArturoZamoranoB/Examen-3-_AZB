using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen_3__AZB.Clases.ClaseNodo;
using static Examen_3__AZB.Clases.ClasePersona;

namespace Examen_3__AZB.Clases
{
    internal class ClaseListaEnlazada
    {
        public class ListaEnlazada
        {
            public class ListasEnlazadas
            {
                public Nodo Principio { get; set; }
                public int Longitud { get; set; }

                public ListasEnlazadas()
                {
                    Principio = null;
                    Longitud = 0;
                }

                public bool EstaVacia()
                {
                    return Principio == null;
                }

                public void InsertarInicio(Persona persona)
                {
                  Nodo nuevoNodo = new Nodo(persona);
                  nuevoNodo.Siguiente = Principio;
                  Principio = nuevoNodo;
                }

                public void InsertarFinal(Persona persona)
                {
                    Nodo nuevoNodo = new Nodo(persona);
                    if (Principio == null)
                    {
                        Principio = nuevoNodo;
                    }
                    else
                    {
                        Nodo actual = Principio;
                        while (actual.Siguiente != null)
                        {
                            actual = actual.Siguiente;
                        }

                        actual.Siguiente = nuevoNodo;
                    }
                    
                }

                
                
                
                



            }
               

        }
    }
}
