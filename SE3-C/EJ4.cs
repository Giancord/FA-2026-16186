using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class EJ4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número decimal: ");

            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"Raiz cuadrada: {Math.Sqrt(num)}");
            Console.WriteLine($"Redondeado: {Math.Round(num,0)}");
            Console.WriteLine($"Al cubo: {Math.Pow(num, 3)}");
            Console.WriteLine($"Raiz cúbica: {Math.Pow(num, 1 / 3)}");

            



        }
    }
}
