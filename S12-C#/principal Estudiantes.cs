using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_C_
{
    internal class principal_Estudiantes
    {
        static void Main(string[] args)
        {
            //Programa que muestra un menú de opciones usando una clase "Estudiantes".

            Estudiantes e = new Estudiantes();
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
                        e.Eliminar();
                        break;
                    case 4:
                        break;
                    case 5:
                        Environment.Exit(0); //Para cerrar consola.
                        break;

                }
                Console.Write("¿Desea continuar? Presione (s): ");
                continuar = Console.ReadLine().Trim().ToLower(); //Trim quita los espacios en blanco

            } while (continuar=="s");


        }
    }
}
