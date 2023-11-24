using Examen_3__AZB.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3__AZB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseListaEnlazada Lista = new ClaseListaEnlazada();


            Console.WriteLine("Ingrese la longitud de la lista");
            int Longitud = Convert.ToInt32(Console.ReadLine());

           
           
            String Nombre ="";
            int Edad = 0;


            for (int i = 0; i < Longitud; i++)
            {

                Console.WriteLine("Ingrese el nombre de la persona");
                Nombre = Console.ReadLine();


                Console.WriteLine("Ingrse la edad de la persona");
                Edad = Convert.ToInt32(Console.ReadLine());


               

            }



            for (int j = 0; j < Longitud; j++)
            {
                Console.WriteLine("Ingrese el nombre buscar");
                string nombrebuscar = Console.ReadLine();
                if (nombrebuscar == Nombre)
                {
                    Console.WriteLine($"El nombre que busco se encuentra en la poscion{j}");
                    break;
                }
                else
                {
                    Console.WriteLine("El dato buscado no se encuentra en la lista");
                }
            }


        }
    }
}
