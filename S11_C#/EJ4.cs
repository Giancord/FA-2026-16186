using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_C_
{
    internal class EJ4
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Ingrese número {i + 1}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\nARREGLO INGRESA DO");
            foreach (int i in num)
                Console.Write(i + " ");

            Console.Write("\nLISTA DE PARES: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                    Console.Write(num[i] + " ");
            }

        }
    }
}
