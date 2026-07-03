using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S15_C_
{
    internal class EJ3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer índice de la matriz: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo índice de la matriz: ");
            int c = int.Parse(Console.ReadLine());

            int[,] matriz = new int[f, c];
            Random rnd = new Random();

            int[] suma = new int[c];

            Console.WriteLine("MATRIZ: ");
            for (int i = 0; i < f; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = rnd.Next(20,30);
                    suma[j] += matriz[i, j];
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < suma.Length; i++)
            {
                Console.Write(suma[i] + "\t");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
