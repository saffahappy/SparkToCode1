//using System;
//using System.Collections.Generic;

//namespace BankingSystemApp
//{
//    internal class Program
//    {
//        // Shared Data Storage
//        static List<string> customerNames = new List<string>();
//        static List<string> accountNumbers = new List<string>();
//        static List<double> balances = new List<double>();

//        static void Main(string[] args)
//        {
//            bool exitApp = false;

//            while (!exitApp)
//            {
//                Console.WriteLine("\nWelcome to Spark Bank");
//                Console.WriteLine("1. Add  Account");
//                Console.WriteLine("2. Deposit Money");
//                Console.WriteLine("3. Withdraw Money");
//                Console.WriteLine("4. Show Balance");
//                Console.WriteLine("5. Transfer Amount");
//                Console.WriteLine("6. List  Accounts");
//                Console.WriteLine("7. Close Account");
//                Console.WriteLine("8. Exit");

//                Console.Write("Choose an option: ");

//                int choice;

//                try
//                {
//                    choice = int.Parse(Console.ReadLine());
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
//                    continue;
//                }

//                switch (choice)
//                {
//                    case 1:
//                        AddAccount();
//                        break;

//                    case 2:
//                        DepositMoney();
//                        break;

//                    case 3:
//                        WithdrawMoney();
//                        break;

//                    case 4:
//                        ShowBalance();
//                        break;

//                    case 5:
//                        TransferAmount();
//                        break;

//                    case 6:
//                        ListAllAccounts();
//                        break;

//                    case 7:
//                        CloseAccount();
//                        break;

//                    case 8:
//                        exitApp = true;
//                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
//                        break;
//                }
//            }
//        }

//        static void AddAccount()
//        {

//        }

//        static void DepositMoney()
//        {

//        }

//        static void WithdrawMoney()
//        {

//        }

//        static void ShowBalance()
//        {

//        }

//        static void TransferAmount()
//        {

//        }

//        static void ListAllAccounts()
//        {

//        }

//        static void CloseAccount()
//        {

//        }
//    }
//}
//static void AddAccount()
//{
//    Console.Write("Enter Customer Name: ");
//    string name = Console.ReadLine();

//    Console.Write("Enter Account Number: ");
//    string accountNumber = Console.ReadLine();

//    if (accountNumbers.Contains(accountNumber))
//    {
//        Console.WriteLine("This account number already exists.");
//        return;
//    }

//    Console.Write("Enter Initial Deposit: ");

//    double deposit;

//    try
//    {
//        deposit = double.Parse(Console.ReadLine());
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Invalid amount.");
//        return;
//    }

//    if (deposit < 0)
//    {
//        Console.WriteLine("Initial deposit cannot be negative.");
//        return;
//    }

//    customerNames.Add(name);
//    accountNumbers.Add(accountNumber);
//    balances.Add(deposit);

//    Console.WriteLine("\nAccount Created Successfully!");
//    Console.WriteLine("Customer Name : " + name);
//    Console.WriteLine("Account Number: " + accountNumber);
//    Console.WriteLine("Balance       : " + deposit);
//}

//static void DepositMoney()
//{
//    Console.Write("Enter Account Number: ");
//    string accountNumber = Console.ReadLine();

//    int index = accountNumbers.IndexOf(accountNumber);

//    if (index == -1)
//    {
//        Console.WriteLine("Account not found.");
//        return;
//    }

//    Console.Write("Enter Deposit Amount: ");

//    double amount;

//    try
//    {
//        amount = double.Parse(Console.ReadLine());
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Invalid amount.");
//        return;
//    }

//    if (amount <= 0)
//    {
//        Console.WriteLine("Deposit amount must be greater than zero.");
//        return;
//    }

//    balances[index] += amount;

//    Console.WriteLine("Deposit Successful.");
//    Console.WriteLine("Updated Balance: " + balances[index]);
//}

//theres error
//static void WithdrawMoney()
//{
//    Console.Write("Enter Account Number: ");
//    string accountNumber = Console.ReadLine();

//    int index = accountNumbers.IndexOf(accountNumber);

//    if (index == -1)
//    {
//        Console.WriteLine("Account not found.");
//        return;
//    }

//    Console.Write("Enter Withdrawal Amount: ");

//    double amount;

//    try
//    {
//        amount = double.Parse(Console.ReadLine());
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Invalid amount.");
//        return;
//    }

//    if (amount <= 0)
//    {
//        Console.WriteLine("Withdrawal amount must be greater than zero.");
//        return;
//    }

//    if (amount > balances[index])
//    {
//        Console.WriteLine("Insufficient balance.");
//        return;
//    }

//    balances[index] -= amount;

//    Console.WriteLine("Withdrawal Successful.");
//    Console.WriteLine("Updated Balance: " + balances[index]);
//}

//static void ShowBalance()
//{
//    Console.Write("Enter Account Number: ");
//    string accountNumber = Console.ReadLine();

//    int index = accountNumbers.IndexOf(accountNumber);

//    if (index == -1)
//    {
//        Console.WriteLine("Account not found.");
//        return;
//    }

//    Console.WriteLine("\nAccount Details");
//    Console.WriteLine("----------------------");
//    Console.WriteLine("Customer Name : " + customerNames[index]);
//    Console.WriteLine("Account Number: " + accountNumbers[index]);
//    Console.WriteLine("Balance       : " + balances[index]);
//}

//static void TransferAmount()
//{
//    Console.Write("Enter Sender Account Number: ");
//    string sender = Console.ReadLine();

//    int senderIndex = accountNumbers.IndexOf(sender);

//    if (senderIndex == -1)
//    {
//        Console.WriteLine("Sender account not found.");
//        return;
//    }

//    Console.Write("Enter Receiver Account Number: ");
//    string receiver = Console.ReadLine();

//    int receiverIndex = accountNumbers.IndexOf(receiver);

//    if (receiverIndex == -1)
//    {
//        Console.WriteLine("Receiver account not found.");
//        return;
//    }

//    Console.Write("Enter Transfer Amount: ");

//    double amount;

//    try
//    {
//        amount = double.Parse(Console.ReadLine());
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Invalid amount.");
//        return;
//    }

//    if (amount <= 0)
//    {
//        Console.WriteLine("Transfer amount must be greater than zero.");
//        return;
//    }

//    if (amount > balances[senderIndex])
//    {
//        Console.WriteLine("Insufficient balance.");
//        return;
//    }

//    balances[senderIndex] -= amount;
//    balances[receiverIndex] += amount;

//    Console.WriteLine("\nTransfer Successful!");
//    Console.WriteLine(customerNames[senderIndex] + " Balance: " + balances[senderIndex]);
//    Console.WriteLine(customerNames[receiverIndex] + " Balance: " + balances[receiverIndex]);
//}
//static void ListAllAccounts()
//{
//    if (customerNames.Count == 0)
//    {
//        Console.WriteLine("No accounts found.");
//        return;
//    }

//    Console.WriteLine("\n===== All Accounts =====");

//    for (int i = 0; i < customerNames.Count; i++)
//    {
//        Console.WriteLine("-------------------------");
//        Console.WriteLine("Customer Name : " + customerNames[i]);
//        Console.WriteLine("Account Number: " + accountNumbers[i]);
//        Console.WriteLine("Balance       : " + balances[i]);
//    }
//}

//static void CloseAccount()
//{
//    Console.Write("Enter Account Number: ");
//    string accountNumber = Console.ReadLine();

//    int index = accountNumbers.IndexOf(accountNumber);

//    if (index == -1)
//    {
//        Console.WriteLine("Account not found.");
//        return;
//    }

//    customerNames.RemoveAt(index);
//    accountNumbers.RemoveAt(index);
//    balances.RemoveAt(index);

//    Console.WriteLine("Account closed");
//}
