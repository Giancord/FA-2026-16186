using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class cuadrado
    {
        public void Area()
        {
            Console.WriteLine("Ingrese el lado: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl área del cuadrado es: {l1*l1}");
        }

        public void Perimetro()
        {
            Console.WriteLine("Ingrese el lado: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl perímetro del cuadrado es: {l1*4}");
        }

    }
}
