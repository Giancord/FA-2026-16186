using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_C_
{
    internal class EJ2
    {
        static void Main(string[] args)
        {
            int intentos = 3;
            Random rnd = new Random();  //rnd es el nombre que se le da a random. Luego se tendrá que almacenar en otra variable.

            int aleatorio = rnd.Next(1,21);  //Next(), dentro del parentesis va el rango de aleatoriedad, desde el primero hasta el segundo-1.

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|    BIENVENIDO AL JUEGO ADIVINADOR    |");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("-------------INSTRUCCIONES--------------");
            Console.WriteLine("1. Tiene solo 3 intentos.");
            Console.WriteLine("2. El número a adivinar está en el rango de 1-20\n");

            do
            {

                Console.Write("Ingrese un número para dar una pista: ");
                int num = int.Parse(Console.ReadLine());
                intentos--;

                if (num > aleatorio)
                {
                    Console.WriteLine($"El número {num} es mayor que el número aleatorio.");
                    Console.WriteLine($"Le quedan {intentos} intentos restantes");
                }
                else if (num < aleatorio) 
                {
                    Console.WriteLine($"El número {num} es menor que el número aleatorio.");
                    Console.WriteLine($"Le quedan {intentos} intentos restantes");
                }
                else
                {
                    Console.WriteLine($"\nLo lograste, el número aleatorio era {aleatorio}.");
                    break;
                }
                if (intentos == 0) 
                {
                    Console.WriteLine($"¡PERDISTE! El número era {aleatorio}.");
                }


            }
            while (intentos > 0);


        }

    }
}
