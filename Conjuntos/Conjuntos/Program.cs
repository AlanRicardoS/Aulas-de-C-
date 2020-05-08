using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            A.ExceptWith(B);
            A.UnionWith(B);
            A.IntersectWith(B);



            B.Add(4);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in B)
            {
                Console.WriteLine(item);
            }
            Console.Write("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());
            if (B.Contains(n))
            {
                Console.WriteLine(n+" pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(n+" não pertence ao conjunto B");
            }
            B.Remove(5);


        }
    }
}
