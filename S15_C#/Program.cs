using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S15_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar;
            productos p = new productos();
            do
            {
                Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGISTRO DE PRODUCTOS\n");
                Console.WriteLine("1. Registrar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Salir");

                Console.Write("Ingrese una opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        p.Registrar();
                        break;
                    case 2:
                        p.Mostrar();
                        break;
                    case 3:
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.Write("¿Desea continuar? [s]");
                continuar = Console.ReadLine();
                Console.Clear();

            } while (continuar == "s");


        }
    }
}
