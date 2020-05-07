using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Lista_ligada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string> { "Maria", "Alex", "Bob" };

            list.Add("Michael");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Maria");
            list.Add("João");
            list.Add("Matarazzo");
            list.Add("Policarpo");
            list.Insert(3, "Felipe");
                
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List count: " + list.Count);
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Position First A: " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position A: "+ pos2);

            List<string> result = list.FindAll(x => x.Length >= 5);
            Console.WriteLine("--------------------");
            foreach (var item in result)
            {
                Console.WriteLine("["+item+"]");
            }
            list.Remove("Alex");
            Console.WriteLine("--------------------");
            foreach (var item in list)
            {
                Console.Write("[" + item + "]");
            }
            Console.WriteLine();
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------");
            foreach (var item in list)
            {
                Console.Write("[" + item + "]");
            }
            list.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine("--------------------");
            foreach (var item in list)
            {
                Console.Write("[" + item + "]");
            }
            list.RemoveRange(0, 2);
            Console.WriteLine();
            Console.WriteLine("--------------------");
            foreach (var item in list)
            {
                Console.Write("[" + item + "]");
            }


        }

    }
}
