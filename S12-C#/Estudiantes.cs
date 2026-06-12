using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace S12_C_
{
    internal class Estudiantes
    {
        //Definir variables al principio

        byte[] edad = new byte[0]; //el dato tipo byte permite valores desde 0 a 255.
        int cantidad = 0;


        public int Menu()
        {
            int opc;

            Console.WriteLine("BIENVENIDO AL SISTEMA DE REGISTRO DE EDADES\n");
            Console.WriteLine("---------- MENÚ DE OPCIONES----------");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Ordenar");
            Console.WriteLine("5. Salir");
            Console.WriteLine("-------------------------------------\n");

            do
            {
                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc<=0 || opc>5);

            return opc;


        }




        public void Insertar()
        {
            Console.Write("\nIngrese la edad: ");
            byte ed; //Para que el while entre al bucle

            //Lo que el usuario ingresa, es capturado por consola, convertido a byte(0-120)
            //y almacenado en "ed",pero si falla se muestra un mensaje

            while (!byte.TryParse(Console.ReadLine(), out ed) || ed> 120 || ed<14) 
            //TryParse : si es que la conversión falla, se ejecuta el code dentro de while (recomendado para valores númericos)
            {
                Console.Write("\nIngrese una edad entre 14 y 120: ");

            }

            //Se redimensiona unicamente cuando un número ingresado es válido, agregar condicional.
            Array.Resize(ref edad, edad.Length+1);//Incrementa o redimensiona los espacios en un arreglo (pa cambiar de un número a otro)

            edad[cantidad] = ed;
            cantidad++;
            Console.WriteLine("\nEdad registrada correctamente.");
        }

        public void Mostrar()
        {
            Console.WriteLine("\nLista de edades: \n");
            Console.Write("POS\tEDAD\n");
            for (int i = 0; i < edad.Length; i++)
            {
                Console.Write($"{i+1}\t {edad[i]}\n");
            }
        }

        public void Eliminar()
        {
            Console.Write("Ingrese la edad a eliminar: ");
            byte ed;

            while (!byte.TryParse(Console.ReadLine(), out ed) || ed > 120 || ed < 14)
            {
                Console.Write("\nIngrese una edad entre 14 y 120: ");
            }

            int indice = Array.IndexOf(edad, ed); //permite buscar el índice de la variable a buscar, devuelve de 0 a +.
            //Si no existe el valor buscado, devuelve -1.
            if (indice != -1)
            {
                //Al eliminar un valor, se borra pero el espacio de memoria queda vacío.
                //Para eliminar valores en un arreglo: se lleva el valor a eliminar a la posición final con +1s,
                for (int i = indice; i < cantidad - 1; i++)
                {
                    edad[i] = edad[i + 1];
                }
                //luego se redimensiona con "Array.Resize" y "-1" para eliminar el 4 y su espacio de memoria.
                Array.Resize(ref edad, edad.Length-1);
                cantidad--;
                Console.WriteLine("\nEdad eliminada correctamente.");
            }
            else Console.WriteLine("\nLa edad no existe. No se puede eliminar");


        }


    }


        
    
}
