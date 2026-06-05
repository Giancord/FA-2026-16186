using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_C_
{
    internal class EJ2
    {
        static void Main(string[] args)
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };

            Console.WriteLine("ARREGLO ORIGINAL");
            foreach (int i in num)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("\n\nARREGLO REEMPLAZADO CON 0");

            for (int i= 0; i<num.Length;i++)
            {
                if (num[i] < 0)
                
                    num[i] = 0;
                    
                Console.WriteLine(num[i] + " ");
            }

        }
    }
}
