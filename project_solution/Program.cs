//namespace project_solution
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
//                Console.WriteLine(" welcome to  bank ");
//                Console.WriteLine("add account");
//                Console.WriteLine("deposit");
//                Console.WriteLine("withdraw");
//                Console.WriteLine(" balance");
//                Console.WriteLine("transfer");
//                Console.WriteLine(" list accounts");
//                Console.WriteLine("close ");
//                Console.WriteLine("exit");

//                Console.Write("choose option: ");

//                int choice;

//                try
//                {
//                    choice = int.Parse(Console.ReadLine());
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("invalid input.");
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
//                        Console.WriteLine("Thank you for using our serivces");
//                        break;

//                    default:
//                        Console.WriteLine("nvalid option");
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
//    Console.Write("enter  Name: ");
//    string name = Console.ReadLine();

//    Console.Write("enter account number: ");
//    string accountNumber = Console.ReadLine();

//    if (accountNumbers.Contains(accountNumber))
//    {
//        Console.WriteLine("This account  already exist");
//        return;
//    }

//    Console.Write("enter  deposit: ");

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
//        Console.WriteLine(" deposit cant be negative.");
//        return;
//    }

//    customerNames.Add(name);
//    accountNumbers.Add(accountNumber);
//    balances.Add(deposit);

//    Console.WriteLine("account Created");
//    Console.WriteLine("customer name : " + name);
//    Console.WriteLine("account number: " + accountNumber);
//    Console.WriteLine("balance       : " + deposit);
//}

//static void DepositMoney()
//{
//    Console.Write("Enter Account Number: ");
//    string accountNumber = Console.ReadLine();

//    int index = accountNumbers.IndexOf(accountNumber);

//    if (index == -1)
//    {
//        Console.WriteLine("account not found.");
//        return;
//    }

//    Console.Write("enter amount: ");

//    double amount;

//    try
//    {
//        amount = double.Parse(Console.ReadLine());
//    }
//    catch (Exception)
//    {
//        Console.WriteLine("Invalid");
//        return;
//    }

//    if (amount <= 0)
//    {
//        Console.WriteLine("deposit amount must be greater than zero.");
//        return;
//    }

//    balances[index] += amount;

//    Console.WriteLine("deposit Successful.");
//    Console.WriteLine("balance: " + balances[index]);
//}
static void WithdrawMoney()
{
    Console.Write("enter account number: ");
    string accountNumber = Console.ReadLine();

    int index = accountNumbers.IndexOf(accountNumber);

    if (index == -1)
    {
        Console.WriteLine("account not found.");
        return;
    }

    Console.Write("enter withdrawal amount: ");

    double amount;

    try
    {
        amount = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("invalid amount.");
        return;
    }

    if (amount <= 0)
    {
        Console.WriteLine("withdrawal amount must be greater than zero");
        return;
    }

    if (amount > balances[index])
    {
        Console.WriteLine("balance not enough");
        return;
    }

    balances[index] -= amount;

    Console.WriteLine("Withdrawal Successful.");
    Console.WriteLine(" Balance: " + balances[index]);
}

static void ShowBalance()
{
    Console.Write("Enter Account Number: ");
    string accountNumber = Console.ReadLine();

    int index = accountNumbers.IndexOf(accountNumber);

    if (index == -1)
    {
        Console.WriteLine("Account not found.");
        return;
    }

    Console.WriteLine("account details");
    Console.WriteLine("----------------------");
    Console.WriteLine("customer name : " + customerNames[index]);
    Console.WriteLine("account number: " + accountNumbers[index]);
    Console.WriteLine("your balance is : " + balances[index]);
}

static void TransferAmount()
{
    Console.Write("enter sender number:");
    string sender = Console.ReadLine();

    int senderIndex = accountNumbers.IndexOf(sender);

    if (senderIndex == -1)
    {
        Console.WriteLine("sender account not found.");
        return;
    }

    Console.Write("Enter  account number: ");
    string receiver = Console.ReadLine();

    int receiverIndex = accountNumbers.IndexOf(receiver);

    if (receiverIndex == -1)
    {
        Console.WriteLine(" account not found.");
        return;
    }

    Console.Write("enter amount to transfer: ");

    double amount;

    try
    {
        amount = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid amount.");
        return;
    }

    if (amount <= 0)
    {
        Console.WriteLine("transfer amount must be greater than zero.");
        return;
    }

    if (amount > balances[senderIndex])
    {
        Console.WriteLine("not enough balance.");
        return;
    }

    balances[senderIndex] -= amount;
    balances[receiverIndex] += amount;

    Console.WriteLine("transfer Successful!");
    Console.WriteLine(customerNames[senderIndex] + " Balance: " + balances[senderIndex]);
    Console.WriteLine(customerNames[receiverIndex] + " Balance: " + balances[receiverIndex]);
}
