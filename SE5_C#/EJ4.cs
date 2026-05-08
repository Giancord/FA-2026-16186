using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C_
{
    internal class EJ4
    {
        static void Main(string[] args)
        {
            int pares, impares, cero, cant, nums, cantnum;

            Console.Write("Ingrese la cantidad de números que desea tipear: ");
            cant = int.Parse(Console.ReadLine());
            cantnum = 0;
            pares = 0;
            impares = 0;
            cero = 0;
            do
            {
                Console.Write("Ingrese un número: ");
                nums = int.Parse(Console.ReadLine());
                cantnum++;

                if (nums % 2 == 0) 
                {
                    pares++;
                }
                if (nums % 2 != 0)
                {
                    impares++;
                }
                if (nums == 0) 
                {
                    cero++;
                }
            }
            while(cantnum<cant);

            Console.WriteLine($"La cantidad de números pares es: {pares}.");
            Console.WriteLine($"La cantidad de números impares es: {impares}.");
            Console.WriteLine($"La cantidad de ceros es: {cero}.");
        }
    }
}
