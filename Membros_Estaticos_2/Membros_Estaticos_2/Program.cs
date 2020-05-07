using Membros_Estaticos_2;
using System;
using System.Globalization;

namespace Membros_Estaticos
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre com valor do raio");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Cirucunferência :" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume :" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valo de pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}
