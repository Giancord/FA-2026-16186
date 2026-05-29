using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class trapecio
    {
        public void Area()
        {
            Console.WriteLine("Ingrese la base menor: ");
            int basem = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la base mayor: ");
            int baseM = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura: ");
            int altura = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n El área del rectángulo es: {((basem *+baseM)/2)}");
        }

        public void Perimetro()
        {

        }
    }
}
