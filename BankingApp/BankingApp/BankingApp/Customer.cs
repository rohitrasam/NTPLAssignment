using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Customer
    {
        private string name;
        private int accountNumber;
        private double balance;
        private bool isPrime;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        private static int accountNumberSeed = 121;

        private Customer(string Name, double Balance)
        {
            this.Name = Name;
            this.AccountNumber = accountNumberSeed;
            this.Balance = Balance;
            accountNumberSeed++;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public static Customer CreateCustomer(string Name, double Balance)
        {
            return new Customer(Name, Balance);
        }
    }
}
