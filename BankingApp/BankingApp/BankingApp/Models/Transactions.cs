using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Transactions
    {
        public double Amount
        {
            get; private set;
        }

        public DateTime Date { get; private set; }

        public Transactions(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
