using System;

namespace Bloco_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int result = a/b;
            
            try
            {
                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
