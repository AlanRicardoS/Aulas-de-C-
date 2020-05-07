using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Entre com o valor da posição "+i+": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for(int j = 0; j < n; j++)
            {
                sum += vect[j];
                Console.Write("["+vect[j]+"]");
            }
            double avg = sum / n;
            Console.WriteLine("\nAVERAGE HEIGHT = "+avg.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
