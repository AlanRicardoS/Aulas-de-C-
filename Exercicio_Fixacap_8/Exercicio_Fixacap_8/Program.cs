using Exercicio_Fixacap_8.Entitites;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Fixacap_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'i')
                {
                    Console.Write("Customs fee:");
                    double custom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, custom));

                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price,manufacture));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
                

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.PriceTag());
            }

        }
    }
}
