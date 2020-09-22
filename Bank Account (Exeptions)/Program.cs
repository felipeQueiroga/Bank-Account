using Aula.Entities.Exeptions;
using System;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            String holder;
            int number;
            double amount;
            double withdrawLimit;

            List<Account> lsit = new List<Account>();

            try
            {
                Console.WriteLine("Account number:");
                number = int.Parse(Console.ReadLine());

                Console.WriteLine("Account holder:");
                holder = Console.ReadLine();

                Console.WriteLine("Initial balance:");
                amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Withdraw limit:");
                withdrawLimit = double.Parse(Console.ReadLine());

                Account c = new Account(number, holder, amount, withdrawLimit);
                Console.WriteLine(c.ToString());

                Console.WriteLine("Enter amount for withdraw:");
                double amountWithdraw = double.Parse(Console.ReadLine());
                c.Withdraw(amountWithdraw);

                Console.WriteLine(c.ToString());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Account: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
