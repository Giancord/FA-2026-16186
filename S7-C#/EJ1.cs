using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_C_
{
    internal class EJ1
    {
        static void Main(string[] args)
        {

            int cantidad, pares, impares,num;

            pares = 0;
            impares = 0;
            cantidad = 0;

            do
            {
                Console.Write("Ingrese un número, negativo para finalizar: ");
                num = int.Parse(Console.ReadLine());
                cantidad++;

                if (num % 2 == 0 && num>0) 
                {
                    pares++;
                }
                else if (num % 2 != 0 && num>0)
                {
                    impares++;
                }


            }
            while (num>0);
            Console.WriteLine($"\nSe han ingresado {pares} números pares.");
            Console.WriteLine($"Se han ingresado {impares} números impares.");
        }
    }
}
