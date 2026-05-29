using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class triangulo
    {
        public void Area() 
        {
            //Para abrir la biblioteca dll click en el proyecto biblioteca y "abrir carpeta en el explorador de windows"

            Console.WriteLine("Ingrese la base: ");
            int baase = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n El área del triángulo es: {(baase * altura) / 2}");
        }

        public void Perimetro() 
        {
            Console.WriteLine("Ingrese el primer lado: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado: ");
            int l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer lado: ");
            int l3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl perímetro del triángulo es: {l1 + l2 + l3}");
        }

    }
}
