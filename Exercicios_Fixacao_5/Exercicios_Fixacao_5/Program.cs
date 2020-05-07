using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicios_Fixacao_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            Console.Write("Entre a seguir com o números de Funcionários: ");
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario "+(i+1)+":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Funcionario p = new Funcionario(id, nome, salario);
                lista.Add(p);
                Console.WriteLine();
            }
            Console.WriteLine();
            while (true)
            {
                Console.Write("Entre com o número do id do funcionário para aumentar o salário: ");
                int busca_id = int.Parse(Console.ReadLine());
                int pos = 0;
                pos = lista.FindIndex(x => x.ID == busca_id);
                
                if (pos >= 0)
                {
                    Console.Write("Entre com a porcentagem que será aumentado no salário do funcionário: ");
                    double novo_salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista[pos].Salario += (lista[pos].Salario * (novo_salario / 100));
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("ID não existe no sistema!");
                }
            }
            Console.WriteLine("Lista Atualizada: ");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            
            
            
        }
    }
}
