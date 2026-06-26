using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese sus nombres: ");
            string nom = Console.ReadLine().Trim();
            Console.Write("Ingrese sus apellidos: ");
            string ape = Console.ReadLine().Trim();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#Caracteres de apellidos: " + ape.Length); //Devuelve cantidad de caracteres de la variable apellidos.

            Console.WriteLine($"Nombres: {nom.ToUpper()}");
            Console.WriteLine($"Apellidos: {ape.ToUpper()}");


            if (ape.CompareTo(nom) == 0) //ComparteTo retorna 0 cuando los valores comparados son iguales (ape y nom)
            {
                Console.WriteLine("Apellidos y nombres iguales.");
            }
            else
            {
                Console.WriteLine("Apellidos y nombres diferentes.");
            }


            if (nom.Contains("an") == true) //Si es true significa que dentro de la variable nom, está contenida la palabra an.
            {
                Console.WriteLine("En nombres, contiene 'an'.");
            }
            else
            {
                Console.WriteLine("En nombres, no contiene 'an'.");
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            if (ape.IndexOf("a") == -1) //Retorna -1 si no existe el texto buscado.
            {
                Console.WriteLine("No existe la letra 'a' en apellidos");
            }
            else
            {
                Console.WriteLine($"Existe 'a' en apellidos en la posición: {ape.IndexOf("a")}");

            }


            if (ape.LastIndexOf("a") == -1) //Retorna -1 si no existe el texto buscado.
            {
                Console.WriteLine("No existe la letra 'a' en apellidos");
            }
            else
            {
                Console.WriteLine($"La última 'a' en apellidos se encuentra en la posición: {ape.LastIndexOf("a")}");

            }

            Console.WriteLine(nom.Insert(0, "UPN"));
            Console.WriteLine(ape.Insert(ape.Length, "SISTEMAS"));


            if (ape.Length > 5)
            {
                ape.Remove(5);
            }
            else
            {
                Console.WriteLine("No contiene 5 caracteres o más.");
            }

            if (nom.Contains("a"))
            {
                Console.WriteLine(nom.Replace("a", "@"));  //Reemplaza cada "a" por "@".
            }
            else
            {
                Console.WriteLine("No existe la letra 'a' en nombres.");
            }

            //IMPORTANTE:---------------------------------------------------------------------------------------


            //Si se usa un caracter para separar un texto, los caracteres encontrados actuan como espacios
            //(pos 0 corresponde desde el primer caracter a la izq y así)
            //Cada separación queda almacenada en la posición de un arreglo.

            //EJ: CALABAZA -> C L B Z -> [1] [2] [3] [4]

            if (nom.Contains("a"))
            {
                string[] partes = nom.Split('a'); //Se crea un arreglo cuyos índices almacenan las partes separadas por cada "a".
                for (int i = 0; i < partes.Length; i++)
                {
                    Console.Write(partes[i] + " ");
                }
            }
            else 
            {
                Console.WriteLine("No existe ninguna letra 'a' en nombres.");
            }

            //--------------------------------------------------------------------------------------------------

            //Subcadena a partir de 4ta pos:

            if (nom.Length > 4)
            {
                Console.WriteLine(nom.Substring(4)); //Crea subcadena desde la 4ta pos.
            }
            else 
            {
                Console.WriteLine("En nombres, no hay por lo menos 4 caracteres.");
            }

            //Convertir nombres a arreglo e imprimir verticalmente.

            char[] vertical = nom.ToCharArray(); //Convierte nom a un arreglo de tipo char.

            foreach (char c in vertical)
                Console.WriteLine(c);


            //Nombre en reversa:

            char[] reversa = nom.ToCharArray(); //Convierte nom a un arreglo de tipo char.
            Array.Reverse(reversa);
            foreach (char c in reversa)
                Console.Write(c);

            //Ordenar alfabeticamente el texto de nombre:

            Console.WriteLine();

            char[] ordenado = nom.ToCharArray(); //Convierte nom a un arreglo de tipo char.
            Array.Sort(ordenado);
            foreach (char c in ordenado)
                Console.Write(c);

        }
    }
}
