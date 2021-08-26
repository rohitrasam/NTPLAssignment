using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Customer
    {

        public List<Transactions> Transactions { get; private set; }

        public string Name { get; private set;}
        public string AccountNumber { get; private set;}
        public double Balance { get; private set; }

        private Guid accountNumberSeed = Guid.NewGuid();

        public Customer(string Name, double Balance)
        {
            Transactions = new List<Transactions>();
            this.Name = Name;
            AccountNumber =  accountNumberSeed.ToString().Substring(0, 13);
            CustomerTransactions(Balance);

        }

        public void CustomerTransactions(double amount)
        {
            Balance += amount;
            Transactions transaction = new Transactions(amount, DateTime.Now);
            Transactions.Add(transaction);
        }
    }
}
