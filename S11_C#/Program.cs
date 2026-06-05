using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJEMPLO 1:

            int[] num = new int[5];
            for (int i =0; i < num.Length; i++) 
            {
                Console.WriteLine($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nLISTA DE NÚMEROS INGRESADOS: ");
            foreach (int i in num) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
