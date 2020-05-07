using System;
using System.Globalization;

namespace Exercicio_de_Fixacao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            Console.Write("Entre com o Número da conta: ");
            int conta = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com o nome do Titular: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito Incial (s/n)? ");
            string resposta = Console.ReadLine();
            if(resposta == "s"|| resposta== "sim" || resposta == "S" || resposta == "SIM")
            {
                Console.Write("Entre com o valor inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else
            {
                saldo = 0;
            }
            Cliente p = new Cliente(nome, saldo, conta);
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(p);

            Console.Write("Entre com o valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Deposito(deposito);

            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(p);

            Console.Write("Entre com o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Saque(saque);

            Console.WriteLine("Dados Atualizados:");
            Console.WriteLine(p);







        }
    }
}
