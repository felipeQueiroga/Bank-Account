using Aula.Entities.Exeptions;
using System;
using System.Collections.Generic;
using System.Text;


namespace Aula
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public static double Tax = 5.0;
        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Deposit(balance);
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount && (WithdrawLimit == 0 || amount <= WithdrawLimit))
            {
                Balance -= amount;
            }
            else if (!(WithdrawLimit == 0 || amount <= WithdrawLimit))
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else
            {
                throw new DomainException("You have no balance to withDraw");
            }
        }
        public override String ToString()
        {
            return "Number: " + Number +
              ", Holder: " + Holder +
              ", Balance: " + Balance +
              ", Withdraw: " + WithdrawLimit;
        }
    }
}
