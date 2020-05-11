using Abstracao_Exercico_Resolvido.Entities;
using Abstracao_Exercico_Resolvido.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstracao_Exercico_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Entre the number of shapes:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circule (r/c):");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));

                }
                else
                {
                    Console.Write("Raius: ");
                    double raius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circule(raius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");

            foreach (var item in list)
            {
                Console.WriteLine(item.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
