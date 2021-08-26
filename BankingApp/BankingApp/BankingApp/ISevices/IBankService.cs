using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.ISevices
{
    public interface IBankService
    {
        bool AddCustomer(Customer customer);
        bool Deposit(string accountNumber, double amount);
        bool Withdraw(string accountNumber, double amount);
        void ShowAllTransactions(string accountNumber);
        void CheckBalance(string accountNumber);
    }
}
