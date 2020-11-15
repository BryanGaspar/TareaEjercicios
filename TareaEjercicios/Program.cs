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
            int x = 7;

            Console.WriteLine("El cuadrado de {0} es : {1} ", x, cuadrado(x));
            figura();
            Console.WriteLine("El factorial de {0} es: {1} ", x, factorialNumero(x));
            numeroParImpar(x);


            Console.ReadKey();
        }
        //Tarea Crear dos funciones con condicionales y con bucles repetitivos
        //#1 Condicional if
        static void numeroParImpar( int num)
        {
         
            if (num % 2 == 0)
            {
                Console.Write("El numero {0} es par ", num);
            }
            else
            {
                Console.Write("El numero {0} es impar ", num);
            }

        }
        //#2 Bucle Repetitivo (While)
        static int factorialNumero(int num)
        {
            int fac = 1, x = 1;
            while (x <= num)
            {
                fac = fac * x;
                x = x + 1;
            }
                return fac;

        }
        static void figura()
        {
            Console.WriteLine("Figura:");
            Console.WriteLine("   *    ");
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
