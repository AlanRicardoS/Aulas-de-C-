using Abstracao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Ana", 500.0, 500.0));

            double sum = 0.0;
            foreach (var item in list)
            {
                sum += item.Balance;
            }
            Console.WriteLine("Total Balance:" + sum.ToString("F2", CultureInfo.InvariantCulture));
            foreach (var item in list)
            {
                item.Withdraw(10.0);
            }
            foreach (var item in list)
            {
                Console.WriteLine("Update balance for account " + item.Number + ": "
                    + item.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
