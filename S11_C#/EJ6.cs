using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S11_C_
{
    internal class EJ6
    {
        static void Main(string[] args)
        {

            string[] nom = new string[5];
            string eva;
            int registrados = 0;
            


            for (int i = 0;  registrados< nom.Length; i++)
            {
                Console.Write($"Ingrese nombre {registrados + 1}: ");
                eva = Console.ReadLine();
                bool duplicado = false;


                for (int j =0; j<nom.Length; j++)
                {
                    if (nom[j] == eva)
                    {
                        Console.Write("El nombre ingresado ya ha sido registrado. Ingrese otro: ");
                        duplicado = true;
                        break;
                    }

                }
                if (!duplicado)
                {
                    nom[registrados] = eva;
                    registrados++;
                }

            }

            Console.WriteLine("\nLISTA DE NOMBRES: ");
            foreach (string s in nom) 
            {
                Console.Write(s + " ");
            }



        }
    }
}
