using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankingApp
{
    public class Bank
    {
        private string name;
        private string branchName;
        public string Name { 
            get { return name; }
            private set { name = value; } 
        }
        public string BranchName { 
            get { return branchName; }
            private set { branchName = value; }
        }

        public List<Customer> ListOfCustomers;
        public Bank(string Name, string BranchName)
        {
            this.BranchName = BranchName;
            this.Name = Name;
            ListOfCustomers = new List<Customer>();
        }
    }
}
