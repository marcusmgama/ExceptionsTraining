using ExceptionsTraining.Entities;
using ExceptionsTraining.Entities.Exceptions;

namespace ExceptionsTraining.Entities
{
    internal class Account
    {
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public int Number { get; set; }
        public string Holder { get; set; }

        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance <= 0 || Balance <= amount)
            {
                throw new DomainException("Not enough balance.");
            }
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }

            Balance -= amount;
        }
    }
}
