using BankingApp.ISevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankingApp.Services
{
    public class BankService : IBankService
    {
        private readonly Bank bank;
        public BankService(Bank bank)
        {
            this.bank = bank;
        }
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

        private Customer FindCustomer(int accountNumber)
        {
            return bank.ListOfCustomers.Where(c => c.AccountNumber == accountNumber).FirstOrDefault();
        }

        public bool Deposit(int accountNumber, double amount)
        {
            var customer = FindCustomer(accountNumber);
            if (amount > 0)
            {
                customer.DepositWithdraw(amount);
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
                customer.DepositWithdraw(-amount);
                Console.WriteLine($"Amount of Rs.{amount} withdrawn successfully.");
                return true;
            }
            Console.WriteLine("Failed to withdraw amount. Not enough money to withdraw\n");
            return false;
        }

        public void ShowAllTransactions(int accountNumber)
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

        public void CheckBalance(int accountNumber)
        {
            var customer = FindCustomer(accountNumber);
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Balance.: Rs.{customer.Balance}\n");
        }

    }
}
