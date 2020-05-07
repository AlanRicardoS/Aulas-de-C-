using System;
using System.Globalization;

namespace Exercicios_de_Fixacao_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = " +  
                Calcularoda.Conversor(dolar,qtd).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
