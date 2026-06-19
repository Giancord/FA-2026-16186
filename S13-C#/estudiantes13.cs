using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S13_C_
{
    internal class estudiantes13
    {
        string[] nombre = new string[0];
        byte[] edad = new byte[0]; //el dato tipo byte permite valores desde 0 a 255.
        int cantidad = 0;
        
            


        public int Menu()
        {
            int opc;

            Console.WriteLine("BIENVENIDO AL SISTEMA DE REGISTRO DE EDADES\n");
            Console.WriteLine("---------- MENÚ DE OPCIONES----------");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Buscar");
            Console.WriteLine("4. Modificar");
            Console.WriteLine("5. Eliminar");
            Console.WriteLine("6. Ordenar");
            Console.WriteLine("7. Salir");
            Console.WriteLine("-------------------------------------\n");

            do
            {
                Console.Write("Ingrese una opción: ");
                opc = int.Parse(Console.ReadLine());
            } while (opc <= 0 || opc > 5);

            return opc;


        }


        public void Insertar()
        {
            Console.Write("\nIngrese el nombre: ");
            string nom = Console.ReadLine();
            Console.Write("\nIngrese la edad: ");
            byte ed = byte.Parse(Console.ReadLine()) ;

            Array.Resize(ref nombre, nombre.Length + 1);
            Array.Resize(ref edad, edad.Length + 1);
            nombre[cantidad] = nom;
            edad[cantidad] = ed;
            cantidad++;

            Console.WriteLine("Nombre y edad registrados con éxito.");
          
        }

        public void Mostrar()
        {

            Console.WriteLine("\nLista de nombres y edades: \n");
            Console.Write("PO\tNOMBRE\tEDAD\n");
            for (int i = 0; i < edad.Length; i++)
            {
                Console.Write($"{i + 1}\t {nombre[i]}\t{edad[i]}\n");          
            }
        }

        public int Buscar(string nom)
        {
            int indice = -1;

            for (int i = 0; i < nombre.Length; i++)
            {

                if (nom == nombre[i])
                    indice = i;
            }
            return indice;
            
        }

        public void Modificar()
        {
            Console.Write("Ingrese el nombre: ");
            string nom = Console.ReadLine();

            int modi = Buscar(nom);

            if (modi != -1)
            {
                Console.Write("\nIngrese el nuevo nombre: ");
                nombre[modi] = Console.ReadLine();
                Console.Write("\nIngrese la nueva edad: ");
                edad[modi] = byte.Parse(Console.ReadLine());
                Console.WriteLine("\nNombre y edad modificados correctamente.");

            }
            else Console.WriteLine("\nNo existe el nombre.");
        }



        public void Eliminar()
        {
            Console.Write("Ingrese el nombre a eliminar: ");
            string nom = Console.ReadLine();

            int eli = Buscar(nom);

            if (eli != -1)
            {
                for (int i = eli; i < nombre.Length - 1; i++)
                {
                    nombre[eli] = nombre[eli + 1];
                    edad[eli] = edad[eli + 1];
                }
                //luego se redimensiona con "Array.Resize" y "-1" para eliminar el 4 y su espacio de memoria.
                Array.Resize(ref nombre, nombre.Length - 1);
                Array.Resize(ref edad, edad.Length - 1);
                cantidad--;
                Console.WriteLine("\nNombre y edad eliminada correctamente.");

            }
            else Console.WriteLine("\nNo existe el nombre.");
        }


        public void Ordenar()
        {

            
            for (int i = 0; i < edad.Length - 1; i++)
            {
                for (int j = 0; j < edad.Length - 1 - i; j++)
                {
                    if (string.Compare(nombre[j], nombre[j+1])>0) //Si se quiere descendente cambiar el signo a <
                    {
                        byte temporal = edad[j];
                        edad[j] = edad[j + 1];
                        edad[j + 1] = temporal;

                        string temp2 = nombre[j];
                        nombre[j] = nombre[j + 1];
                        nombre[j + 1] = temp2;

                    }
                }
            }
        }




    }


}

