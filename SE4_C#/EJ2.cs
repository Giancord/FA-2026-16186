using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C_
{
    internal class EJ2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un año: ");

            int año = int.Parse(Console.ReadLine());
            // El if indica si el año es bisiesto

            if ((año % 4 == 0 && año % 100 != 0) || año % 400 == 0)
            {
                Console.WriteLine("\nEl año es bisiesto.");
            }
            else 
            {
                Console.WriteLine("\nEl año no es bisiesto.");
            }

            if (año % 2 == 0) Console.WriteLine("El año es par.");
            else Console.WriteLine("El año es impar.");

        }


    }
}
