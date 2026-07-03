using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S15_C_
{
    internal class EJ2
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el tamaño de la matriz cuadrada: ");
            int t = int.Parse(Console.ReadLine());

            int[,] matriz = new int[t, t];
            Random rnd = new Random();

            Console.WriteLine("MATRIZ ORIGINAL: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    matriz[i, j] = rnd.Next(40, 51);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("MATRIZ TRANSPUESTA: ");
            for (int i = 0; i < t; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    Console.Write(matriz[j, i] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
