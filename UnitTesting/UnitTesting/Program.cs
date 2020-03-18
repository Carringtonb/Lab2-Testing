using System;

namespace UnitTesting
{
    public class Program
    {
        public static decimal balance = 420;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            decimal number = 0;
           
        }

        //public static int ViewBalance(decimal number)
        //{
        //    if (number > 0)
        //    {
        //        return number;
        //    }
        //}

        public static decimal Withdrawal(decimal number)
        {
            if (balance <= 0)
            {
                Console.WriteLine("You are out of money");
            }
            else if (balance > 0)
            {
                balance -= number;
            }
            return balance;
        }
    }
}

