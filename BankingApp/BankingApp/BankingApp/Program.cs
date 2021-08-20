using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.AddCustomer(Customer.CreateCustomer("Rohit", 5000, true));
        }
    }
}
