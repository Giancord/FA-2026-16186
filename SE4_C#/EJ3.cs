using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C_
{
    internal class EJ3
    {
        static void Main(string[] args)
        {

            double conv;
            string option;

            conv = 0;
            option ="soles";

            Console.WriteLine("Ingrese un monto (soles): ");
            double monto = double.Parse(Console.ReadLine());


            Console.WriteLine("---Opciones---");
            Console.WriteLine("\n(1) Convertir a dólares.");
            Console.WriteLine("(2) Convertir a euros.\n");
            int ops = int.Parse(Console.ReadLine());

            switch (ops) 
            {
                case 1:
                    option = "dolares";
                    conv = monto/ 3.75;
                    Console.WriteLine($"\nLa conversión de {monto} soles a {option} es de {conv}.");
                    break;
                case 2:
                    option = "euros";
                    conv = monto/ 4.05;
                    Console.WriteLine($"\nLa conversión de {monto} soles a {option} es de {conv}.");
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción incorrecta.");
                    break;
                    
            }



        }


    }
}
