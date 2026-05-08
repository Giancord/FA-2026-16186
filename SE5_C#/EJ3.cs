using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C_
{
    internal class EJ3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad: ");
            int cant = int.Parse(Console.ReadLine());
            int suma;

            suma = 0;

            for (int i = 1; i <= cant; i++) 
            {
                Console.WriteLine(i);
                if (i % 2 == 0) 
                {
                    suma += i;
                    
                }
            }
            Console.WriteLine($"La suma de pares es: {suma}.");
        }
    }
}
