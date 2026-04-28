using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C_
{
    internal class EJ2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer lado del triángulo: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado del triángulo: ");
            int l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer lado del triángulo: ");
            int l3 = int.Parse(Console.ReadLine());


            if (l1 == l2 && l1 == l3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (l1 == l2 || l2 == l3 || l1 == l3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else 
            {
                Console.WriteLine("El triángulo es escaleno.");
            }

                


            
            

            
        }
    }
}
