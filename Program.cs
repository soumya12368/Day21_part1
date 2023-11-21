using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet17_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string accountHolderName = Console.ReadLine();

            // Create an instance of BankAccount
            BankAccount myAccount = new BankAccount(accountHolderName);

            // Print initial account details
            Console.WriteLine("Initial Account Details:");
            myAccount.PrintAccountDetails();

            // Deposit
            Console.Write("Enter the deposit amount: ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            myAccount.Deposit(depositAmount);

            // Withdraw
            Console.Write("Enter the withdrawal amount: ");
            decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
            myAccount.Withdraw(withdrawalAmount);

            // Print final account details
            Console.WriteLine("Final Account Details:");
            myAccount.PrintAccountDetails();
        }
    }
    class BankAccount
    {
        // Properties
        public int AccountNumber { get; }
        public string AccountHolderName { get; set; }
        private decimal Balance { get; set; }

        // Constructor
        public BankAccount(string accountHolderName)
        {
            // Generate a unique account number 
            AccountNumber = GenerateAccountNumber();
            AccountHolderName = accountHolderName;
            Balance = 0;
        }

        // Method to generate a unique account number 
        private int GenerateAccountNumber()
        {
            // Replace this with your logic to generate a unique account number
            return new Random().Next(100000, 999999);
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited: ${amount}");
                PrintAccountDetails();
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount}");
                PrintAccountDetails();
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        // Method to print account details
        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: ${Balance}");
            Console.WriteLine();
        }
    }
}
