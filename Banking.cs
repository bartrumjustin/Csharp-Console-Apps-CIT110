
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBalance
    {
        public class Banking
        {
            public static int Transactions { get; set; } = 0;
            public string Account { get; set; }
            public string AccountName { get; set; }
            public double Balance { get; set; }
            public double Withdrawals { get; set; }
            public double Deposits { get; set; }

        public void PrintAccount()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine($"       Transaction # {Transactions}  Account # {Account}  Account Name:  {AccountName} ");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");

        }

        public Banking()
            {
                
                Account = string.Empty;
                AccountName = string.Empty;
                Balance = 0;
                Withdrawals = 0;
                Deposits = 0;
            }
            public void IncreaseTransactions()
            {
               Transactions++;
            }
            public void DecreaseTransactions()
            {
                Transactions--;
            }
            public void CalculateNewBalance()
            {
                Balance = Balance + Deposits - Withdrawals;
            }
            
            public void PrintTotalWithdrawals()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Total Withdrawals: {Withdrawals:C}");
            }
            public void PrintTotalDeposits()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"   Total Deposits: {Deposits:C}");
            }
            public void PrintBalance(string? prefix)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (!String.IsNullOrEmpty(prefix) || !String.IsNullOrWhiteSpace(prefix))
                    Console.Write($"{prefix}{Balance:C}");
                else
                    Console.Write($"Here is your balance: {Balance:C}");
                Console.WriteLine();
            }
        }
    }

