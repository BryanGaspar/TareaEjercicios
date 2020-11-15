using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            static void figura()
            {
                Console.WriteLine("    *    ");
                Console.WriteLine("   *   ");
                Console.WriteLine("  ***  ");
                Console.WriteLine(" ***** ");
            }

            //Crear la función que devuelva un parámetro entero y devuelva el cuadrado de ese entero
            static int cuadrado(int a)
            {
                int cuadrado = a * a;
                return cuadrado;
            }
        }
    }
}
