using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp
{
    public interface Customer
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }


    }
}
