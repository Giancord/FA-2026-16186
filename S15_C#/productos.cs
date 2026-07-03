using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S15_C_
{
    internal class productos
    {
        string[,] productos1 = new string[0,3];
        int cantidad = 0;

        public void Redimensionar(int nuevoT)
        {
            string[,] temp = new string[nuevoT, 3];

            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = productos1[i, j];

                }
            }
            productos1 = temp;

        }

        public void Registrar() 
        {
            Redimensionar(cantidad + 1);
            Console.Write("Ingrese el nombre del producto: ");
            productos1[cantidad, 0] = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            productos1[cantidad, 1] = Console.ReadLine();

            Console.Write("Ingrese el stock del producto: ");
            productos1[cantidad, 2] = Console.ReadLine();

            Console.WriteLine("Registro completo.");
            cantidad++;

        }

        public void Mostrar()
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\nProducto N°" + (i + 1));
                Console.WriteLine("Nombre: " + productos1[i, 0]);

                Console.WriteLine("Precio: " + productos1[i, 1]);

                Console.WriteLine("Stock: " + productos1[i, 2]);


            }

        }

    }
}
