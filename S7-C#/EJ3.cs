using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_C_
{
    internal class EJ3
    {
        static void Main(string[] args)
        {
            string continuar;
            int suma = 0, i=1;

            do
            {
                Console.Clear();  //Limpia la consola cuando se reinicia el bucle.
                Console.Write("Ingrese un número positivo: ");
                int num = int.Parse(Console.ReadLine());

                do
                {
                    suma++;
                    i++;
                }
                while (i<=num);

                Console.WriteLine($"\nLa suma desde 1 hasta {num} es {suma}.");

                Console.Write("\n¿Desea continuar? (S) para seguir: ");
                continuar = Console.ReadLine();
                
                
            }
            while (continuar=="S");
            
           
        }
    }
}
