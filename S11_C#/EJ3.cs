using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_C_
{
    internal class EJ3
    {
        static void Main(string[] args)
        {
            int[] num = { 10,50,6,3,7,20 };

            Console.WriteLine("ARREGLO");
            foreach (int i in num)
            {
             
                Console.WriteLine(i + " ");
             
            }
            int min = num[0];
            int max = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)

                    min = num[i];

                if (num[i] > max)

                    max = num[i];

            }
            Console.WriteLine($"\nMinimo: {min}");
            Console.WriteLine($"\nMáximo: {max}");
        }


    }
}
