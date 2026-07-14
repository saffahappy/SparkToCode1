//namespace task1_oop
//{
//    internal class BankAccount
//    {
//        public int AccountNumber { get; set; }
//        public string HolderName { get; set; }
//        public double Balance { get; set; }

//        // Case 16
//        public BankAccount()
//        {

//        }

//        public BankAccount(int accountNumber, string holderName, double balance)
//        {
//            AccountNumber = accountNumber;
//            HolderName = holderName;
//            Balance = balance;
//        }

//        // Case 18
//        public bool IsOverdrawn
//        {
//            get { return Balance < 0; }
//        }

//        public void Deposit(double amount)
//        {
//            Balance += amount;
//            SendEmail();
//        }

//        public void Withdraw(double amount)
//        {
//            if (Balance >= amount)
//            {
//                Balance -= amount;
//                SendEmail();
//            }
//            else
//            {
//                Console.WriteLine("not enough balance.");
//            }
//        }

//        public double CheckBalance()
//        {
//            PrintInformation();
//            return Balance;
//        }

//        private void PrintInformation()
//        {
//            Console.WriteLine($"holder Name : {HolderName}");
//            Console.WriteLine($"balance     : {Balance}");
//        }

//        private void SendEmail()
//        {
//            Console.WriteLine("Email notification is sent.");
//        }
//    }
//}