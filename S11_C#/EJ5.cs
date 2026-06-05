using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_C_
{
    internal class EJ5
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la cantidad de números a ingresar: ");
            int cant = int.Parse(Console.ReadLine());

            int[] num = new int[cant];

            int suma = 0;

            Console.WriteLine(); //Da un salto en blanco

            for (int i = 0; i < num.Length; i++) 
            {
                Console.WriteLine($"Ingrese número {i+1}");
                num[i] = int.Parse(Console.ReadLine());
                suma += num[i];
            }

            Console.Write("\n\nLISTA DE NÚMEROS: ");
            foreach (int i in num)
                Console.Write(i + " ");

            Console.Write($"\nSuma total: {suma}");

        }
    }
}
