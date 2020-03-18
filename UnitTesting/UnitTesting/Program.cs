using System;

namespace UnitTesting
{
    public class Program
    {
        public static decimal balance = 420;

        static void Main()
        {
            Console.WriteLine("Hello Welcome To Powerful ATM!");

            //decimal number = 0;
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Close ATM");

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                ViewBalance();
                Main();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Enter amount to Withdraw");
                string withdraw = Console.ReadLine();
                decimal convertedInput = Convert.ToDecimal(userInput);
                Withdrawal(convertedInput);
                Main();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Enter amount to Deposit");
                string deposit = Console.ReadLine();
                decimal convertedDeposit = Convert.ToDecimal(deposit);
                DepositFunds(convertedDeposit);
                Main();
            }
            else if(userInput == "4");
                    {

            }
        }

        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your balance is {balance}");
           

            if (balance > 0)
            {
                return balance;
            }
            return 0;
        }

        public static decimal Withdrawal(decimal number)
        {
            if (balance <= 0)
            {
                Console.WriteLine("You are out of money");
                return balance;
            }
            else if (balance > 0)
            {
                balance -= number;
                Console.WriteLine($"Your new balance is {balance}");
            }
            return balance;
        }

        public static decimal DepositFunds(decimal number)
        {
            if (number > 0)
            {
                balance += number;
                Console.WriteLine($"Your new balance is {balance}");
                return balance;
            }
            else if (number <= 0)
            {
                Console.WriteLine("You must deposit a positive number");
            }
            return balance;
        }
    }
}

