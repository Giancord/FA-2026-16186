using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C_
{
    internal class EJ4_MODO2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de números: ");
            int cant = int.Parse(Console.ReadLine());

            int num, cceros = 0, cpares=0, cimpares=0 ;
            Console.WriteLine();
            for (int i = 0; i < cant; i++) 
            {
                Console.Write($"Ingrese número {i + 1}:");
                num = int.Parse(Console.ReadLine());

                if (num == 0) cceros++;
                else if (num % 2 == 0) cpares++;
                else cimpares++;
            }
            Console.WriteLine("\n\nCantidad ceros: " + cceros);
            Console.WriteLine("Cantidad pares: " + cpares);
            Console.WriteLine("Cantidad impares: " + cimpares);

        }
    }
}
