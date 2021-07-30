using System;
using ContaBancaria.Entities;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
           Account acc1 = new Account(1001,"alex",500.0);
           Account acc2 = new SavingAccount(1002, "Anna",450.0, 0.01);

           acc1.Withdraw(10.0);
           acc2.Withdraw(15.0);

           Console.WriteLine(acc1.Balance);
           Console.WriteLine(acc2.Balance);
           
        }
    }
}
