using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> teste = null;
            //  double a = null; -> erro
            double? x = null;
            double? y = 10.0;
            Console.WriteLine(x.GetValueOrDefault()); // Apresenta o valor ou o valor padrão -> nesse caso é 0. X é double, onde o valor padrão é 0
            Console.WriteLine(y.GetValueOrDefault()); // Apresenta o valor 10.
            Console.WriteLine(x.HasValue); // Apresenta se a variavel possui um valor. Se sim aprenseta True, caso contrario apresenta false.
            Console.WriteLine(y.HasValue); // Apresenta o valor True

            if (x.HasValue) // X Possui um valor?
            {
                Console.WriteLine(x.Value); // apresenta o valor de x
            }
            else
            {
                Console.WriteLine("X is Null"); // Caso uma varia seja nula e seja utilizado a função HasValue sobre ela, o programa retorna uma erro.
            }
            if (y.HasValue) // y possui um valor?
            {
                Console.WriteLine(y.Value); // apresneta o valor de Y
            }
            else
            {
                Console.WriteLine("y is Null");
            }

            double a = x ?? 5;
            double b = y ?? 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
        
        }

    }
}
