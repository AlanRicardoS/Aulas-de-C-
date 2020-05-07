using System;
using System.Globalization;

namespace Problema_1_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            double areax, areay;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areax = x.Area();
            Console.WriteLine("área de x:" + areax);
            areay = y.Area();
            Console.WriteLine("área de y:" + areay);

            if (areax == areay)
            {
                Console.WriteLine("as áreas tem o mesmo tamanho");
            }
            else
            {
                if (areax > areay)
                {
                    Console.WriteLine("a área de X é a maior");
                }
                else
                {
                    Console.WriteLine("a area de Y é a maior");
                }
            }
        }
    }
}
