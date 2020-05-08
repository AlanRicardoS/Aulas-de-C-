using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "sunday";
                    break;
                case 2:
                    day = "monday";
                    break;
                case 3:
                    day = "tuesday";
                    break;
                case 4:
                    day = "wednesday";
                    break;
                case 5:
                    day = "friday";
                    break;

                case 6:
                    day = "saturday";
                    break;
                case 7:
                    day = "sunday";
                    break;
                default:
                    day = "Invalida Value";
                    break;

            }
            Console.WriteLine("day: "+ day );

        }
    }
}
