using System;

namespace Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            Console.Write("Enter deposit amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            Console.Write("Enter withdrawal amount: ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(withdrawAmount);
            Console.WriteLine($"Final Balance: {account.Balance:C}");

            Console.ReadKey();
        }
    }
}
