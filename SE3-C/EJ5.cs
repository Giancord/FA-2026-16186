using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE3_C
{
    internal class EJ5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un número: ");

            string num =Console.ReadLine();

            int entero = int.Parse(num);
            double decim = double.Parse(num);

            Console.WriteLine($"\nEl resto del número entre 2 es: {entero%2}");

            
           
            Console.WriteLine($"La división del número entre 3 es: {decim/3}");

            
        }
    }
}
