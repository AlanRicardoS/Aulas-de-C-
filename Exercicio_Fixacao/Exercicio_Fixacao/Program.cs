using System;
using System.Globalization;
namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Funcionario: "+ p);
            
            Console.WriteLine();

            Console.Write("Digite a porcetagem para aumentar o salário: ");
            double ptc = double.Parse(Console.ReadLine());
            p.AumentaSalario(ptc);
            Console.WriteLine("Funcionario: " + p);

        }
    }
}
