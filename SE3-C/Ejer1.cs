using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class Ejer1
    {

        static void Main(string[] args)
        {

            string n, c;

            Console.Write("Ingrese su nombre: ");

            n = Console.ReadLine();

            Console.Write("\nIngrese su carrera: ");

            c = Console.ReadLine();

            Console.WriteLine("\n------ IMPRESIÓN CON + ------");
            Console.WriteLine(n + ", Bienvenido al curso FA de la carrera " + c);


            Console.WriteLine("\n------ IMPRESIÓN CON $ ------");
            Console.WriteLine($"{n}, Bienvenido al curso FA de la carrera  {c}");
            Console.ReadKey();






        }
    }
}
