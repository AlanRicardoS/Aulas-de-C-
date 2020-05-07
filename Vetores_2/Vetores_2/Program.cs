using System;
using System.Globalization;

namespace Vetores_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Produto { Nome = name, Preco = price };
            }
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Preco;
            }
            double avg = soma / n;
            Console.WriteLine("AVERAGE PRICE = "+ avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
