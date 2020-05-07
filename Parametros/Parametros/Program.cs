using System;

namespace Parametros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    int s1 = Calculadora.Sum(2, 3);
                int s2 = Calculadora.Sum(2, 4, 3);

                Console.WriteLine(s1);
                Console.WriteLine(s2);
            */
            int a = 10;
            int triple = 0;
            Calculadora.Triple(a, out triple); // ref está passando o valor por referência
            Console.WriteLine(triple);
    }
    }
}
