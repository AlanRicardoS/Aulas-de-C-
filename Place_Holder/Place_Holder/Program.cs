using System;
namespace Place_Holder
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 324354;
            string nome = "Alan";

            //Console.Write(nome);
            //Console.Write(" tem ");
            //Console.Write(idade);
            //Console.Write(" anos ");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome,idade,saldo);

        }
    }
}
