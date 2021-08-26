using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankingApp
{
    public class Bank
    {
        public string Name { get; private set;  }
        public string BranchName { get; private set; }

        public List<Customer> ListOfCustomers { get; private set; }
        public Bank(string Name, string BranchName)
        {
            this.BranchName = BranchName;
            this.Name = Name;
            ListOfCustomers = new List<Customer>();
        }
    }
}
