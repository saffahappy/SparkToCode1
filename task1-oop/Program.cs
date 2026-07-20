//using task1_oop;

//namespace task1_oop
//{
//    internal class BankAccount
//    {
//        public int AccountNumber { get; set; }
//        public string HolderName { get; set; }
//        public double Balance { get; set; }

//        Case 16
//        public BankAccount()
//        {

//        }

//        public BankAccount(int accountNumber, string holderName, double balance)
//        {
//            AccountNumber = accountNumber;
//            HolderName = holderName;
//            Balance = balance;
//        }

//        Case 18
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

//        Case 19
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

//        Case 17
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

//namespace task1_oop
//{


//    namespace OOP_Project
//    {
//        internal class Product
//        {
//            public string ProductName { get; set; }
//            public double Price { get; set; }
//            public int StockQuantity { get; set; }

//            public void Sell(int quantity)
//            {
//                if (StockQuantity >= quantity)
//                {
//                    StockQuantity -= quantity;
//                }
//                else
//                {
//                    Console.WriteLine("Not enough stock.");
//                }

//                LogTransaction();
//            }

//            public void Restock(int quantity)
//            {
//                StockQuantity += quantity;
//                LogTransaction();
//            }

//            public double GetInventoryValue()
//            {
//                PrintDetails();
//                return Price * StockQuantity;
//            }

//            private void PrintDetails()
//            {
//                Console.WriteLine($"Product : {ProductName}");
//                Console.WriteLine($"Price   : {Price}");
//                Console.WriteLine($"Stock   : {StockQuantity}");
//            }

//            private void LogTransaction()
//            {
//                Console.WriteLine("Transaction Logged.");
//            }
//        }
//    }
//}


//namespace task1_oop
//{
//    internal class Program
//    {
//        static BankAccount account1 = new BankAccount
//        {
//            AccountNumber = 2222,
//            HolderName = "sara",
//            Balance = 344
//        };

//        static BankAccount account2 = new BankAccount
//        {
//            AccountNumber = 15203,
//            HolderName = "Ali",
//            Balance = 63
//        };

//        static Student student1 = new Student
//        {
//            Name = "Ali",
//            Address = "Muscat",
//            Grade = 65
//        };

//        static Student student2 = new Student
//        {
//            Name = "Ahmed",
//            Address = "Muscat",
//            Grade = 70
//        };

//        static Product product1 = new Product
//        {
//            ProductName = "Wireless Mouse",
//            Price = 5.5,
//            StockQuantity = 50
//        };

//        static Product product2 = new Product
//        {
//            ProductName = "Mechanical Keyboard",
//            Price = 15.75,
//            StockQuantity = 20
//        };

//        static void Main(string[] args)
//        {
//            bool exit = false;

//            while (!exit)
//            {
//                Console.WriteLine("MENU");
//                Console.WriteLine("1. View Account Details");
//                Console.WriteLine("2. Update Student Address");
//                Console.WriteLine("3. Deposit");
//                Console.WriteLine("4. Withdraw");
//                Console.WriteLine("5. View Product");
//                Console.WriteLine("6. Register Student");
//                Console.WriteLine("7. Compare Accounts");
//                Console.WriteLine("8. Restock Product");
//                Console.WriteLine("9. Transfer Money");
//                Console.WriteLine("10. Update Grade");
//                Console.WriteLine("11. Student Report");
//                Console.WriteLine("12. Account Health");
//                Console.WriteLine("13. Bulk Sale");
//                Console.WriteLine("14. Scholarship Check");
//                Console.WriteLine("15. Balance Top-up");
//                Console.WriteLine("16. Quick Account Opening");
//                Console.WriteLine("17. Student Counter");
//                Console.WriteLine("18. Overdrawn Check");
//                Console.WriteLine("19. Set Student PIN");
//                Console.WriteLine("20. Exit");

//                Console.Write("\nChoose: ");
//                int choice = Convert.ToInt32(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        Case 1
//                        break;

//                    case 2:
//                        Case 2
//                        break;

//                    case 3:
//                        Case 3
//                        break;

//                    case 4:
//                        Case 4
//                        break;

//                    case 5:
//                        Case 5
//                        break;

//                    case 6:
//                        Case 6
//                        break;

//                    case 7:
//                        Case 7
//                        break;

//                    case 8:
//                        Case 8
//                        break;

//                    case 9:
//                        Case 9
//                        break;

//                    case 10:
//                        Case 10
//                        break;

//                    case 11:
//                        Case 11
//                        break;

//                    case 12:
//                        Case 12
//                        break;

//                    case 13:
//                        Case 13
//                        break;

//                    case 14:
//                        Case 14
//                        break;

//                    case 15:
//                        Case 15
//                        break;

//                    case 16:
//                        Case 16
//                        break;

//                    case 17:
//                        Case 17
//                        break;

//                    case 18:
//                        Case 18
//                        break;

//                    case 19:
//                        Case 19
//                        break;

//                    case 20:
//                        exit = true;
//                        break;

//                    default:
//                        Console.WriteLine("Invalid Choice.");
//                        break;
//                }
//            }
//        }
//    }
//}

////Q1
//static void ViewAccount()
//{
//    Console.Write("Choose Account (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    if (choice == 1)
//        account1.CheckBalance();
//    else if (choice == 2)
//        account2.CheckBalance();
//    else
//        Console.WriteLine("Invalid account.");
//}
//Q2
//static void UpdateAddress()
//{
//    Console.Write("Choose Student (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("New Address: ");
//    string address = Console.ReadLine();

//    if (choice == 1)
//    {
//        student1.Address = address;
//        Console.WriteLine("Updated: " + student1.Address);
//    }
//    else if (choice == 2)
//    {
//        student2.Address = address;
//        Console.WriteLine("Updated: " + student2.Address);
//    }
//}
//Q3:
//static void Deposit()
//{
//    Console.Write("Choose Account (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Amount: ");
//    double amount = Convert.ToDouble(Console.ReadLine());

//    if (choice == 1)
//    {
//        account1.Deposit(amount);
//        Console.WriteLine(account1.HolderName);
//        Console.WriteLine(account1.Balance);
//    }
//    else if (choice == 2)
//    {
//        account2.Deposit(amount);
//        Console.WriteLine(account2.HolderName);
//        Console.WriteLine(account2.Balance);
//    }
//}
//Q4
//static void Withdraw()
//{
//    Console.Write("Choose Account (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Amount: ");
//    double amount = Convert.ToDouble(Console.ReadLine());

//    if (choice == 1)
//    {
//        account1.Withdraw(amount);
//        Console.WriteLine(account1.Balance);
//    }
//    else if (choice == 2)
//    {
//        account2.Withdraw(amount);
//        Console.WriteLine(account2.Balance);
//    }
//}
//Q5
//static void ViewProduct()
//{
//    Console.Write("Choose Product (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    if (choice == 1)
//        Console.WriteLine("Inventory Value = " + product1.GetInventoryValue());

//    else if (choice == 2)
//        Console.WriteLine("Inventory Value = " + product2.GetInventoryValue());
//}
//Q6
//static void RegisterStudent()
//{
//    Console.Write("Choose Student (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Email: ");
//    string email = Console.ReadLine();

//    if (choice == 1)
//        student1.Register(email);

//    else if (choice == 2)
//        student2.Register(email);

//    Console.WriteLine("Student Registered Successfully.");
//}
//Q7
//static void CompareAccounts()
//{
//    if (account1.Balance > account2.Balance)
//        Console.WriteLine(account1.HolderName + " has more money.");

//    else if (account2.Balance > account1.Balance)
//        Console.WriteLine(account2.HolderName + " has more money.");

//    else
//        Console.WriteLine("Both accounts have equal balance.");
//}
//Q8
//static void Restock()
//{
//    Console.Write("Choose Product (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Quantity: ");
//    int quantity = Convert.ToInt32(Console.ReadLine());

//    Product product;

//    if (choice == 1)
//        product = product1;
//    else
//        product = product2;

//    product.Restock(quantity);

//    if (product.StockQuantity < 10)
//        Console.WriteLine("Low");

//    else if (product.StockQuantity < 50)
//        Console.WriteLine("Moderate");

//    else
//        Console.WriteLine("Well Stocked");
//}
//Q9
//static void Transfer()
//{
//    Console.Write("From Account (1 or 2): ");
//    int from = Convert.ToInt32(Console.ReadLine());

//    Console.Write("To Account (1 or 2): ");
//    int to = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Amount: ");
//    double amount = Convert.ToDouble(Console.ReadLine());

//    BankAccount source = (from == 1) ? account1 : account2;
//    BankAccount destination = (to == 1) ? account1 : account2;

//    if (source.Balance >= amount)
//    {
//        source.Withdraw(amount);
//        destination.Deposit(amount);
//        Console.WriteLine("Transfer Successful.");
//    }
//    else
//    {
//        Console.WriteLine("Transfer Failed.");
//    }
//}
//Q10
//static void UpdateGrade()
//{
//    Console.Write("Choose Student (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("New Grade: ");

//    if (int.TryParse(Console.ReadLine(), out int grade))
//    {
//        if (grade >= 0 && grade <= 100)
//        {
//            if (choice == 1)
//                student1.Grade = grade;
//            else if (choice == 2)
//                student2.Grade = grade;

//            Console.WriteLine("Grade Updated.");
//        }
//        else
//        {
//            Console.WriteLine("Grade must be between 0 and 100.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid grade.");
//    }
//}
//Q11
//static void StudentReport()
//{
//    Console.Write("Choose Student (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Student student = (choice == 1) ? student1 : student2;

//    Console.WriteLine("\n----- REPORT CARD -----");
//    Console.WriteLine($"Name: {student.Name}");
//    Console.WriteLine($"Address: {student.Address}");
//    Console.WriteLine($"Grade: {student.Grade}");

//    if (student.Grade >= 60)
//        Console.WriteLine("Status: Pass");
//    else
//        Console.WriteLine("Status: Fail");
//}
//Q12
//static void AccountHealth()
//{
//    Console.Write("Choose Account (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    BankAccount account = (choice == 1) ? account1 : account2;

//    if (account.Balance < 50)
//        Console.WriteLine("Low Balance");
//    else if (account.Balance <= 1000)
//        Console.WriteLine("Healthy");
//    else
//        Console.WriteLine("Premium");
//}
//Q13
//static void BulkSale()
//{
//    Console.Write("Choose Product (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Product product = (choice == 1) ? product1 : product2;

//    Console.Write("Quantity to Sell: ");
//    int quantity = Convert.ToInt32(Console.ReadLine());

//    if (product.StockQuantity < quantity)
//    {
//        int needed = quantity - product.StockQuantity;
//        Console.WriteLine($"Need {needed} more units.");
//    }
//    else
//    {
//        product.Sell(quantity);

//        double revenue = quantity * product.Price;

//        Console.WriteLine($"Revenue: {revenue}");
//        Console.WriteLine($"Remaining Stock: {product.StockQuantity}");
//    }
//}
//Q14
//static void ScholarshipCheck()
//{
//    Console.Write("Choose Student (1 or 2): ");
//    int studentChoice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Choose Account (1 or 2): ");
//    int accountChoice = Convert.ToInt32(Console.ReadLine());

//    Student student = (studentChoice == 1) ? student1 : student2;
//    BankAccount account = (accountChoice == 1) ? account1 : account2;

//    if (student.Grade >= 80 && account.Balance >= 100)
//    {
//        Console.WriteLine("Eligible");
//    }
//    else
//    {
//        if (student.Grade < 80)
//            Console.WriteLine("Grade condition failed.");

//        if (account.Balance < 100)
//            Console.WriteLine("Balance condition failed.");
//    }
//}
//Q15
//static void TopUp()
//{
//    Console.Write("Choose Account (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    BankAccount account = (choice == 1) ? account1 : account2;

//    double before = account.Balance;

//    if (account.Balance < 50)
//    {
//        double amountNeeded = 100 - account.Balance;

//        account.Deposit(amountNeeded);

//        Console.WriteLine($"Before: {before}");
//        Console.WriteLine($"After : {account.Balance}");
//    }
//    else
//    {
//        Console.WriteLine("No top-up needed.");
//    }
//}

//Q16
//static void OpenAccount()
//{
//    Console.Write("Account Number: ");
//    int number = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Holder Name: ");
//    string name = Console.ReadLine();

//    Console.Write("Starting Balance: ");
//    double balance = Convert.ToDouble(Console.ReadLine());

//    BankAccount newAccount =
//        new BankAccount(number, name, balance);

//    Console.WriteLine("\nAccount Created:");
//    Console.WriteLine($"Number : {newAccount.AccountNumber}");
//    Console.WriteLine($"Name   : {newAccount.HolderName}");
//    Console.WriteLine($"Balance: {newAccount.Balance}");
//}

//Q17
//static void StudentCounter()
//{
//    Console.WriteLine(
//        $"Total Students: {Student.GetStudentCount()}");
//}
//Q18
//static void OverdrawnCheck()
//{
//    Console.Write("Choose Account (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    BankAccount account = (choice == 1) ? account1 : account2;

//    if (account.IsOverdrawn)
//        Console.WriteLine("Account is Overdrawn.");
//    else
//        Console.WriteLine("Account is NOT Overdrawn.");
//}
//Q19
//static void SetPIN()
//{
//    Console.Write("Choose Student (1 or 2): ");
//    int choice = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Enter 4-digit PIN: ");
//    int pin = Convert.ToInt32(Console.ReadLine());

//    if (choice == 1)
//        student1.SecurityPIN = pin;
//    else if (choice == 2)
//        student2.SecurityPIN = pin;

//    Console.WriteLine("PIN Set Successfully.");
//}