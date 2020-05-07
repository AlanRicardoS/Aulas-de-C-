using System;
using System.Globalization;

namespace Membros_Estaticos
{
    class Program
    {
        static double Pi = Math.PI;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor do raio");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Cirucunferência :" + circ.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Volume :" + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valo de pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double circunferencia(double raio)
        {
            return 2 * Pi * raio;
        }
        static double Volume( double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
