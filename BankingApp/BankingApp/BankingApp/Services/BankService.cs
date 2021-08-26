using BankingApp.ISevices;
using System;
using System.Linq;

namespace BankingApp.Services
{
    public class BankService : IBankService
    {
        private readonly Bank bank = new Bank("NIBM Road", "HDFC");
        public bool AddCustomer(Customer customer)
        {
            var cust = FindCustomer(customer.AccountNumber);
            if (cust == null)
            {
                bank.ListOfCustomers.Add(customer);
                Console.WriteLine($"Account for {customer.Name} created successfully\nYour account number is {customer.AccountNumber}\n");
                return true;
            }

            Console.WriteLine("Account already exists");
            return false;
        }

        private Customer FindCustomer(string accountNumber)
        {
            return bank.ListOfCustomers.Where(c => c.AccountNumber.Equals(accountNumber)).FirstOrDefault();
        }

        public bool Deposit(string accountNumber, double amount)
        {
            var customer = FindCustomer(accountNumber);
            if (amount > 0)
            {
                customer.CustomerTransactions(amount);
                Console.WriteLine($"Amount of Rs.{amount} deposited successfully.");
                return true;
            }
            Console.WriteLine("Failed to deposit amount. Enter a positive amount.");
            return false;
        }

        public bool Withdraw(string accountNumber, double amount)
        {
            var customer = FindCustomer(accountNumber);
            if (amount > 0 && customer.Balance - amount > 0)
            {
                customer.CustomerTransactions(-amount);
                Console.WriteLine($"Amount of Rs.{amount} withdrawn successfully.");
                return true;
            }
            Console.WriteLine("Failed to withdraw amount. Not enough money to withdraw\n");
            return false;
        }

        public void ShowAllTransactions(string accountNumber)
        {
            var customer = FindCustomer(accountNumber);
            foreach (var transaction in customer.Transactions)
            {
                if (transaction.Amount > 0)
                {
                    Console.WriteLine("Rs." + transaction.Amount + " deposited on " + transaction.Date);
                }
                else
                {
                    Console.WriteLine("Rs." + Math.Abs(transaction.Amount) + " withdrawn on " + transaction.Date);
                }
            }
        }

        public void CheckBalance(string accountNumber)
        {
            var customer = FindCustomer(accountNumber);
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Balance.: Rs.{customer.Balance}\n");
        }

    }
}
