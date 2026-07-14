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

//namespace task1_oop
//{
//    internal class Student
//    {
//        public int Grade { get; set; }
//        public string Name { get; set; }
//        public string Address { get; set; }

//        private string email;
//        int age;

//        // Case 19
//        private int pin;

//        public int SecurityPIN
//        {
//            set
//            {
//                if (value >= 1000 && value <= 9999)
//                {
//                    pin = value;
//                }
//                else
//                {
//                    Console.WriteLine("pin must be 4 digits.");
//                }
//            }
//        }

//        // Case 17
//        private static int studentCount = 0;

//        public Student()
//        {
//            studentCount++;
//        }

//        public static int GetStudentCount()
//        {
//            return studentCount;
//        }

//        public void Register(string Email)
//        {
//            email = Email;
//            SendEmail();
//        }

//        private void SendEmail()
//        {
//            Console.WriteLine(" email sent.");
//        }
//    }
//}

namespace task1_oop
{


    namespace OOP_Project
    {
        internal class Product
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public int StockQuantity { get; set; }

            public void Sell(int quantity)
            {
                if (StockQuantity >= quantity)
                {
                    StockQuantity -= quantity;
                }
                else
                {
                    Console.WriteLine("Not enough stock.");
                }

                LogTransaction();
            }

            public void Restock(int quantity)
            {
                StockQuantity += quantity;
                LogTransaction();
            }

            public double GetInventoryValue()
            {
                PrintDetails();
                return Price * StockQuantity;
            }

            private void PrintDetails()
            {
                Console.WriteLine($"Product : {ProductName}");
                Console.WriteLine($"Price   : {Price}");
                Console.WriteLine($"Stock   : {StockQuantity}");
            }

            private void LogTransaction()
            {
                Console.WriteLine("Transaction Logged.");
            }
        }
    }
}