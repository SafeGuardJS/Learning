using System;

namespace SeventhProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(150);
            Account account2 = new Account(1000);

            Console.WriteLine(Account.bonus);
        }

        static public int test { get; set; } = 5;
    }

    class Account
    {
        public static decimal bonus = 100;
        public decimal totalSum;
        public Account(decimal sum)
        {
            totalSum = sum + bonus;
        }
    }
}
