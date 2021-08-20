using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Customer
    {
        private string name;
        private int accountNumber;
        private decimal balance;
        private bool isPrime;

        public string Name 
        { 
            get { return name; }
            private set { name = value; } 
        }
        public  int AccountNumber 
        { 
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public decimal Balance 
        { 
            get { return balance; }
            private set { balance = value; }
        }

        public bool IsPrime
        {
            get { return isPrime; }
            set { isPrime = value; }
        }

        private static int accountNumberSeed = 121;

        private Customer(string Name, decimal Balance, bool IsPrime)
        {
            this.Name = Name;
            this.IsPrime = IsPrime;
            this.AccountNumber = accountNumberSeed;
            this.Balance = Balance;
            accountNumberSeed += (234 % 7)+2;
        }

        public static Customer CreateCustomer(string Name, decimal Balance, bool IsPrime)
        {
            return new Customer(Name, Balance, IsPrime);
        }
    }
}
