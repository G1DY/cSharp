using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace OOP.src.Encasulation
{
    public class BankAccount
    {
        private decimal balance;//field encapsulated preventsaccess from outside the class

        public BankAccount(decimal balance)//constructor
        {
            Deposit(balance);
        }
        public decimal GetBalance()//getter method
        {
            return balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException($"Withdrawal amount is less than 0");
            }
            if (amount > balance)
            {
                throw new InvalidDataException("Invalid Request");
            }
            this.balance -= amount;
        }
    }
}