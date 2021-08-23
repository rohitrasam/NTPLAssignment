using System;

namespace BankingApp
{
    class Program
    {
        static Bank bank = new Bank("NIBM Road", "HDFC");
        static void Main(string[] args)
        {
            bool quit = false;
            while(!quit)
            {
                Console.WriteLine("\nChoose the following options:");
                Options();
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        Deposit();
                        break;

                    case 3:
                        Withdraw();
                        break;

                    case 4:
                        CheckBalance();
                        break;

                    case 5:
                        ShowTransactions();
                        break;

                    case 6:
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Enter a a valid choice");
                        break;
                }
            }
        }

        public static void Options()
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Show Transactions");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
        }

        public static void ShowTransactions()
        {
            Console.Write("Enter your account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            bank.ShowAllTransactions(accountNumber);
        }
        public static void CreateAccount()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the inital amount to open your account: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            bank.AddCustomer(Customer.CreateCustomer(name, amount));
        }

        public static void Deposit()
        {
            Console.Write("Enter your account number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount to deposit: ");
            double amount = Convert.ToInt32(Console.ReadLine());
            bank.Deposit(accNo, amount);
        }

        public static void Withdraw()
        {
            Console.Write("Enter your account number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount to withdraw: ");
            double amount = Convert.ToInt32(Console.ReadLine());
            bank.Withdraw(accNo, amount);
        }

        public static void CheckBalance()
        {
            Console.Write("Enter your account number: ");
            int accNo = Convert.ToInt32(Console.ReadLine());
            bank.CheckBalance(accNo);
        }
    }
}
