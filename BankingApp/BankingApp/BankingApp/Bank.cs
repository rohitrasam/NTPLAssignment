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
            private set { this.branchName = value; }
        }
        public List<Customer> ListOfCustomers;
        public Bank(string Name, string BranchName)
        {
            this.BranchName = BranchName;
            this.Name = Name;
            ListOfCustomers = new List<Customer>();
        }

        public bool AddCustomer(Customer customer)
        {
            var cust = FindCustomer(customer.AccountNumber);
            if (cust == null)
            {
                ListOfCustomers.Add(customer);
                Console.WriteLine($"Account for {customer.Name} created successfully\nYour account number is {customer.AccountNumber}\n");
                return true;
            }

            Console.WriteLine("Account already exists");
            return false;
        }

        private Customer FindCustomer(int accountNumber)
        {
            return ListOfCustomers.Where(c => c.AccountNumber == accountNumber).FirstOrDefault();
        }

        public bool Deposit(int accountNumber, double amount)
        {
            var customer = FindCustomer(accountNumber);
            if(amount > 0)
            {
                customer.Deposit(amount);
                Console.WriteLine($"Amount of Rs.{amount} deposited successfully.");
                return true;
            }
            Console.WriteLine("Failed to deposit amount. Enter a positive amount.");
            return false;
        }

        public bool Withdraw(int accountNumber, double amount)
        {
            var customer = FindCustomer(accountNumber);
            if (amount > 0 && customer.Balance - amount > 0)
            {
                customer.Withdraw(amount);
                Console.WriteLine($"Amount of Rs.{amount} withdrawn successfully.");
                return true;
            }
            Console.WriteLine("Failed to withdraw amount. Not enough money to withdraw\n");
            return false;
        }

        public void CheckBalance(int accountNumber)
        {
            var customer = FindCustomer(accountNumber);
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Balance.: Rs.{customer.Balance}\n");
        }
    }
}
