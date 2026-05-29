using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblioteca;

namespace S9_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            triangulo t = new triangulo();
            rectangulo r = new rectangulo();
            trapecio tr = new trapecio();
            cuadrado c = new cuadrado();

            string continuar;
            int opc, opc2;
            
            do
            {
                Console.Clear();

                Console.WriteLine("BIENVENIDO AL SISTEMA DE CALCULO DE ÁREAS Y PERÍMETROS.\n");
                Console.WriteLine("1. Triangulo. ");
                Console.WriteLine("2. Cuadrado. ");
                Console.WriteLine("3. Rectángulo. ");
                Console.WriteLine("4. Trapecio. ");
                Console.WriteLine("5. Salir.\n");

                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 1:

                        Console.WriteLine("CÁLCULOS DISPONIBLES: ");
                        Console.WriteLine("1. Área.");
                        Console.WriteLine("2. Perímetro.");
                        Console.Write("\nIngrese una opción: ");
                        opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1:
                                t.Area();
                                break;
                            case 2:
                                t.Perimetro();
                                break;
                            default:
                                Console.WriteLine("\nOpción no válida");
                                break;
                        }

                        break;
                    case 2:

                        Console.WriteLine("CÁLCULOS DISPONIBLES: ");
                        Console.WriteLine("1. Área.");
                        Console.WriteLine("2. Perímetro.");
                        Console.Write("\nIngrese una opción: ");
                        opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1:
                                c.Area();
                                break;
                            case 2:
                                c.Perimetro();
                                break;
                            default:
                                Console.WriteLine("\nOpción no válida");
                                break;
                        }

                        break;
                    case 3:

                        Console.WriteLine("CÁLCULOS DISPONIBLES: ");
                        Console.WriteLine("1. Área.");
                        Console.WriteLine("2. Perímetro.");
                        Console.Write("\nIngrese una opción: ");
                        opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1:
                                r.Area();
                                break;
                            case 2:
                                r.Perimetro();
                                break;
                            default:
                                Console.WriteLine("\nOpción no válida");
                                break;
                        }

                        break;
                    case 4:

                        Console.WriteLine("CÁLCULOS DISPONIBLES: ");
                        Console.WriteLine("1. Área.");
                        Console.WriteLine("2. Perímetro.");
                        Console.Write("\nIngrese una opción: ");
                        opc2 = int.Parse(Console.ReadLine());

                        switch (opc2)
                        {
                            case 1:
                                tr.Area();
                                break;
                            case 2:
                                tr.Perimetro();
                                break;
                            default:
                                Console.WriteLine("\nOpción no válida");
                                break;
                        }

                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }





                Console.Write("¿Desea continuar? Escriba (si): ");
                continuar = Console.ReadLine();
            } while (continuar=="si");
            



            





        }
    }
}
