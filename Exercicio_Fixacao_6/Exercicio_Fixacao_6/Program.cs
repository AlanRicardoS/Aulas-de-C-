
using System;
using System.Threading;

namespace Exercicio_Fixacao_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o tamanho da matriz: ");
            string [] vet = Console.ReadLine().Split(' ');
                       
            int[,] mat = new int[int.Parse(vet[0]),int.Parse(vet[1])];
            
            
            bool []sinal = new bool[int.Parse(vet[1])];

            for (int i = 0; i < int.Parse(vet[0]); i++)
            {
                
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < int.Parse(vet[1]); j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                    
                }
            }

            Console.Write("Entre com o número que você deseja localizar: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < int.Parse(vet[0]); i++)
            {
                for (int j = 0; j < int.Parse(vet[1]); j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Posição: "+i+","+j);
                        if(j-1>=0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                            
                        }
                        if((j + 1) < int.Parse(vet[1]))
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if(i-1>=0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                            
                        }
                        if((i + 1) < int.Parse(vet[0]))
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                        

                    }
                }
            }
            

            for (int i = 0; i < int.Parse(vet[0]); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < int.Parse(vet[1]); j++)
                {
                    Console.Write("["+mat[i,j]+"]");
                }
            }
            Console.WriteLine();

            

        }
        
    }
}
