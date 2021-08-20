using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankingApp
{
    public class Bank
    {
        public string Name { get; set; }
        public string BranchName { get; set; }
        public List<Customer> ListOfCustomers;
        public Bank()
        {
            ListOfCustomers = new List<Customer>();
        }

        public bool AddCustomer(Customer customer)
        {
            if(/*ListOfCustomers == null ||*/ FindCustomer(customer) == null)
            {
                ListOfCustomers.Add(customer);
                Console.WriteLine("Account created successfully");
                return true;
            }

            Console.WriteLine("Account already exists");
            return false;
        }

        private IEnumerable<Customer> FindCustomer(Customer customer)
        {
            return (IEnumerable<Customer>)ListOfCustomers.Where(c => c.AccountNumber == customer.AccountNumber).FirstOrDefault();
        }
    }
}
