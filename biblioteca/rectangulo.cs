using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class rectangulo
    {
        public void Area()
        {
            Console.WriteLine("Ingrese la base: ");
            int baase = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n El área del rectángulo es: {(baase * altura)}");
        }

        public void Perimetro()
        {
            Console.WriteLine("Ingrese el primer lado: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo lado: ");
            int l2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl perímetro del rectángulo es: {(l1 + l2)*2}");
        }
    }
}
