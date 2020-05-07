using System;

namespace Exercicio_Fixacao_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());

            Aluno[] vetor = new Aluno[9];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome Aluno " + (i+1) + ": ");
                string nome = Console.ReadLine();
               
                Console.Write("Email Aluno " + (i+1) + ": ");
                string email = Console.ReadLine();
              
                Console.Write("Quarto Aluno " + (i+1) + ": ");
                int quarto = int.Parse(Console.ReadLine());
                vetor[i] = new Aluno { Nome = nome, Email = email, Quarto = quarto };
            }
            for (int i = 0; i < n; i++)
            {
                if (vetor[i].Quarto != 0)
                {
                    Console.WriteLine(vetor[i].Quarto+": "+vetor[i].Nome+", "+ vetor[i].Email);
                }
                
            }


        }
    }
}
