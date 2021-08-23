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
        private List<Transactions> transactions;

        public List<Transactions> Transactions
        {
            get { return transactions; }
        }

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
            transactions = new List<Transactions>();
            this.Name = Name;
            AccountNumber = accountNumberSeed;
            this.Balance = Balance;
            DepositWithdraw(Balance);
            accountNumberSeed++;
        }

        public void DepositWithdraw(double amount)
        {
            Balance += amount;
            Transactions transaction = new Transactions(amount, DateTime.Now);
            transactions.Add(transaction);
        }

        public static Customer CreateCustomer(string Name, double Balance)
        {
            return new Customer(Name, Balance);
        }
    }
}
