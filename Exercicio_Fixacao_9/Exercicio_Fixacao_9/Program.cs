using Exercicio_Fixacao_9.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Fixacao_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double he = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, he));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }

            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.Name+" $ "+item.Tax().ToString("F2",CultureInfo.InvariantCulture));
            }
            double sum = 0.0;
            foreach (var item in list)
            {
                

                sum += item.Tax();
               
            }
            
            Console.WriteLine("TOTAL TAXES: $ " +sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
