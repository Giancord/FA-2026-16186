using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C_
{
    internal class EJ1
    {
        static void Main(string[] args)
        {
            int edad;


            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Menor de edad");
            if (edad>18 && edad<= 64) Console.WriteLine("Mayor de edad");
            if (edad>=65) Console.WriteLine("Adulto Mayor");


        }


    }
}
