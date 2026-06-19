using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S13_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            estudiantes13 e = new estudiantes13();
            string continuar;

            do
            {
                Console.Clear();
                switch (e.Menu())
                {
                    case 1:
                        e.Insertar();
                        break;
                    case 2:
                        e.Mostrar();
                        break;
                    case 3:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nom = Console.ReadLine();
                        Console.WriteLine($"\nEl nombre existe y esta en la posición {e.Buscar(nom) + 1}");
                        
                        break;
                    case 4:
                        e.Modificar();
                        break;
                    case 5:
                        e.Eliminar();
                        break;
                    case 6:
                        e.Ordenar();
                        

                        break;
                    case 7:
                        Environment.Exit(0); //Para cerrar consola.
                        break;

                }
                Console.Write("¿Desea continuar? Presione [s]: ");
                continuar = Console.ReadLine().Trim().ToLower(); //Trim quita los espacios en blanco

            } while (continuar == "s");

        }
    }
}
