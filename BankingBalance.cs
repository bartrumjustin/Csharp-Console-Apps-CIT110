using System;
using System.Data.Common;
using System.Transactions;
namespace BankBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the account number, quit to end? ");
            string? tempAcct = Console.ReadLine();

            while (tempAcct != "quit")
            {
                Banking transaction = new Banking();

                transaction.Account = ValidateText(tempAcct);

                Console.WriteLine("What is the account name? ");
                transaction.AccountName = ValidateText(Console.ReadLine());

                Console.WriteLine("What is the beginning balance? ");
                string? tempNumber = Console.ReadLine();
                transaction.Balance = ValidateDouble(tempNumber);

                Console.WriteLine("What are the total deposits? ");
                tempNumber = Console.ReadLine();
                transaction.Deposits = ValidateDouble(tempNumber);

                Console.WriteLine("What are the total withdrawals? ");
                tempNumber = Console.ReadLine();
                transaction.Withdrawals = ValidateDouble(tempNumber);

                transaction.IncreaseTransactions();

                transaction.PrintAccount();
                transaction.PrintBalance("Beginning Balance: ");
                transaction.PrintTotalDeposits();
                transaction.PrintTotalWithdrawals();
                if (transaction.Balance + transaction.Deposits - transaction.Withdrawals > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("~~~~~Your transactions are being processed~~~~~");
                    transaction.CalculateNewBalance();
                    transaction.PrintBalance("    Ending Balance:");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine($"             You do not have enough money in your account to complete this transaction");
                    Console.WriteLine($"                              Your transactions have not been processed.");
                    Console.WriteLine($"                          Your ending balance remains the same: {transaction.Balance:C}");
                    Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What is the account number, quit to end? ");
                tempAcct = Console.ReadLine();


            }

        }
        public static string ValidateText(string temp)
        {
            string? value = temp;
            while (String.IsNullOrEmpty(value) || String.IsNullOrEmpty(value))
            {
                Console.WriteLine("The value entered cannot be blank or empty, please try again!");
                value = Console.ReadLine();
            }
            return value;
        }
        public static double ValidateDouble(string temp)
        {
            string? value = temp;
            double number;
            while (!(double.TryParse(value, out number)) && number < 0)
            {
                Console.WriteLine($"Please enter a number with decimal places");
                value = Console.ReadLine();
            }
            return number;
        }
    }
}