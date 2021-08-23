using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public class Transactions
    {
        private double amount;
        private DateTime date;

        public double Amount
        {
            get { return amount; }
            private set { amount = value; }
        }

        public DateTime Date
        {
            get { return date; }
            private set { date = value; }
        }

        public Transactions(double amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
