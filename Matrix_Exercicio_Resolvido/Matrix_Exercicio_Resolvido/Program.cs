using System;
using System.Collections.Generic;

namespace Matrix_Exercicio_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(value[j]);
                }
            }
            Console.WriteLine("Main diaginal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i]+" ");
            }
            Console.WriteLine();
            int negativo = 0;
            foreach (var item in mat)
            {
                if(item < 0)
                {
                    negativo ++;
                }
            }
            Console.WriteLine("Negativos: "+negativo);
        }
    }
}
