using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4_C_
{
    internal class EJ4
    {
        static void Main(string[] args)
        {
            double area;


            Console.WriteLine("------SISTEMA DE CÁLCULO DE ÁREAS------");
            Console.WriteLine("\n(1) Área de un cuadrado.");
            Console.WriteLine("(2) Área de un rectángulo.");
            Console.WriteLine("(3) Área de un triángulo.");
            Console.WriteLine("(4) Área de un círculo.\n");
            int opcion = int.Parse(Console.ReadLine());


            switch (opcion) 
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    double L = double.Parse(Console.ReadLine());
                    area = L * L;
                    Console.WriteLine($"\nEl área del cuadrado es de: {area} metros cuadrados.");
                    break;
                case 2:
                    Console.WriteLine("Ingrese la base del rectángulo: ");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura del rectángulo: ");
                    double a = double.Parse(Console.ReadLine());

                    area = b * a;
                    Console.WriteLine($"\nEl área del rectángulo es de: {area} metros cuadrados.");
                    break;
                case 3:
                    Console.WriteLine("Ingrese la base del triángulo: ");
                    double bt = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la altura del triángulo: ");
                    double at = double.Parse(Console.ReadLine());

                    area = (bt * at)/2;
                    Console.WriteLine($"\nEl área del triángulo es de: {area} metros cuadrados.");
                    break;
                case 4:
                    Console.WriteLine("Ingrese el radio del círculo: ");
                    double r = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(r, 2); ;
                    Console.WriteLine($"\nEl área del círculo es de: {area} metros cuadrados.");
                    break;
                default:
                    Console.WriteLine("Ha ingresado una opción incorrecta.");
                    break;

            }
        }


    }
}
