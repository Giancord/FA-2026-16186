using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5_C_
{
    internal class EJ1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad: ");
            int ed = int.Parse(Console.ReadLine());

            if (ed < 18)
            {
                Console.WriteLine("No puede votar y no puede ejercer un cargo político");
            }
            else 
            {
                Console.WriteLine("Puede votar");
                if (ed < 25)
                {
                    Console.WriteLine("No puede ser candidato.");
                }
                else 
                {
                    Console.WriteLine("Puede ser candidato.");
                }
            }
        }
    }
}
