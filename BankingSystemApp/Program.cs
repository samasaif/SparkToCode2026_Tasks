using System;
using System.Collections.Generic;

namespace BankingSystemApp
{

    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. <your 1st custom service - choose a name>");
                Console.WriteLine("7. <your 2nd custom service - choose a name>");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        SearchCustomer();
                        break;
                    case 7: 
                        ListAllAccounts();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
// ===================== SERVICE FUNCTIONS =====================
// Each function owns ONE service end-to-end: it asks the user for
// whatever it needs, validates it, updates the shared lists, and
// prints the outcome. Main never reads input or prints results
// for these services - it only shows the menu and calls them.

        static void AddAccount()
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();
            
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            
            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Customer already exists. Please choose a different account.");
            }
            Console.WriteLine("Enter an initial deposit amount: ");
            double amount = 0;

            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }

            if (amount < 0)
            {
                Console.WriteLine("Balance cannot be negative. Please try again.");
            }
            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(amount);
            
            Console.WriteLine("Customer added.");
            Console.WriteLine("Customer name: " + customerName);
            Console.WriteLine("Customer number: " + accountNumber);
            Console.WriteLine("Customer balance: " + amount);
        }

        static void DepositMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Customer does not exist.");
            }
            
            Console.WriteLine("Enter amount to deposit: ");
            double amount = 0;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }
            if (amount < 0)
            {
                Console.WriteLine("Balance cannot be negative. Please try again.");
            }
            
            balances[index] += amount;
            
            Console.WriteLine("Customer deposited.");
            Console.WriteLine("Updated balance: " + balances[index]);;
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Customer does not exist.");
            }
            
            Console.WriteLine("Enter amount to withdraw: ");
            double amount = 0;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }
            if (amount < 0)
            {
                Console.WriteLine("Balance cannot be negative. Please try again.");
            }

            if (amount > balances[index])
            {
                Console.WriteLine("Balance cannot be greater than balance.");
            }
            
            balances[index] -= amount;
            
            Console.WriteLine("Customer withdrawed.");
            Console.WriteLine("Updated balance: " + balances[index]);;
        }

        static void ShowBalance()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Customer does not exist.");
            }
            Console.WriteLine("Displaying the details");
            Console.WriteLine("Customer name: " + customerNames[index]);
            Console.WriteLine("Customer number: " + accountNumbers[index]);
            Console.WriteLine("Customer balance: " + balances[index]);
        }

        static void TransferAmount()
        {
            Console.WriteLine("Enter sender's account number: ");
            string senderAccountNumber = Console.ReadLine();
            int senderIndex = accountNumbers.IndexOf(senderAccountNumber);
            
            if (senderIndex == -1)
            {
                Console.WriteLine("Customer does not exist.");
            }
            
            Console.WriteLine("Enter receiver's account number: ");
            string receiverAccountNumber = Console.ReadLine();
            int receiveIndex =  accountNumbers.IndexOf(receiverAccountNumber);
            
            if (receiveIndex == -1)
            {
                Console.WriteLine("Customer does not exist.");
            }
            
            Console.WriteLine("Enter amount to transfer: ");
            double amount = 0;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }

            if (amount < 0)
            {
                Console.WriteLine("Balance cannot be negative.");
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine("Balance cannot be greater than balance.");
            }
            
            balances[senderIndex] -= amount;
            balances[receiveIndex] += amount;
            
            Console.WriteLine("Customer transfered.");
            Console.WriteLine("Updated sender balance: " + balances[senderIndex]);
            Console.WriteLine("Updated receiver balance: " + balances[receiveIndex]);
        } 
        
        // your own custom services (option 6 and option 7)

        static void ListAllAccounts()
        {
            
        }
        
        static void SearchCustomer()
        {
            
        }
    }
}