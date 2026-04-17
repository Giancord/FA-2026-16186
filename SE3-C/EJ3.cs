using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class EJ3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nSuma: {num1+num2}");
            Console.WriteLine($"\nResta: {num1 - num2}");
            Console.WriteLine($"\nMultiplicación: {num1 * num2}");
            Console.WriteLine($"\nDivisión: {num1 / num2}");

        }
    }
}
