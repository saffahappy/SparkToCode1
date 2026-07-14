namespace project_solution
{
    internal class Program
    {
        // Shared Data Storage
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine(" welcome to  bank ");
                Console.WriteLine("add account");
                Console.WriteLine("deposit");
                Console.WriteLine("withdraw");
                Console.WriteLine(" balance");
                Console.WriteLine("transfer");
                Console.WriteLine(" list accounts");
                Console.WriteLine("close ");
                Console.WriteLine("exit");

                Console.Write("choose option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid input.");
                    continue;
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
                        ListAllAccounts();
                        break;

                    case 7:
                        CloseAccount();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for using our serivces");
                        break;

                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
        }

        static void AddAccount()
        {

        }

        static void DepositMoney()
        {

        }

        static void WithdrawMoney()
        {

        }

        static void ShowBalance()
        {

        }

        static void TransferAmount()
        {

        }

        static void ListAllAccounts()
        {

        }

        static void CloseAccount()
        {

        }
    }
}
