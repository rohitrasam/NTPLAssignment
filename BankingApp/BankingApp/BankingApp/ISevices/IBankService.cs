using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.ISevices
{
    public interface IBankService
    {
        bool AddCustomer(Customer customer);
        //Customer FindCustomer(int accountNumber);
        bool Deposit(int accountNumber, double amount);
        bool Withdraw(int accountNumber, double amount);
        void ShowAllTransactions(int accountNumber);
        void CheckBalance(int accountNumber);
    }
}
