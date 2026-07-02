
////Problem1: countdown timer

//Console.WriteLine("Enter number");
//    int num = Convert.ToInt32(Console.ReadLine());
//    for (int x = num; x >= 1; x--)
//    {
//        Console.WriteLine(x);
//    }

//    Console.WriteLine("off of the lift");

//Problem2:sum of numbers:
//Console.Write("Enter a positive number: ");
//int num=Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//for(int x=1;x<=num;x++)
//{
//    sum += int;
//}

//Console.WriteLine("the sum is " + sum);

//problem3:table of multiplication:
//Console.WriteLine("enter number: ");
//int num=Convert.ToInt32(Console.ReadLine());

//for(int x = 1; x<=10;x++)
//{
//    Console.WriteLine(num + "i " + x + "= " + (num * x));
//}

//problem4:password retry
//    string originalpass = "Spark2026";
//    string pass = "";
//    while (pass != originalpass)
//    {
//        Console.Write("Enter your password:");
//        Console.ReadLine();

//        if(pass != originalpass)
//        {
//            Console.WriteLine("password not correct");
//        }

//        Console.WriteLine("access is granted");


//    }
//}

//probelm5:number guessing game
//int numissecret = 42;
//int attempt = 0;
//int guess;

//do
//{
//    Console.Write("enter your number: ");
//    guess = Convert.ToInt32(Console.ReadLine());
//    attempt++;

//    if (guess > numissecret)
//    {
//        Console.WriteLine("high");
//    }
//    else if (guess < numissecret)
//    {
//        Console.WriteLine("low");
//    }
//}
//while (guess!=numissecret);
//Console.WriteLine("number of correct attempt " + attempt);



//problem 6:safe division calculator 
//try
//{ Console.Write("enter first num: ");
//double num1=Convert.ToDouble(Console.ReadLine());

//Console.Write("enter second  num: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//double result = num1 / num2;

//    Console.WriteLine("the result is " + result); 
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("not divided by zero");
//}

//catch (FormatException)
//{
//    Console.WriteLine("invalid");

//}
//catch (Exception)
//{
//    Console.WriteLine("error");

//}





//problem7:repeating menu with eat option
//int choice = 0;
//while(choice!=3)
//{
//    Console.WriteLine("menu list");
//    Console.WriteLine("say hello");
//    Console.WriteLine("say greetings");
//    Console.WriteLine("exit");

//    try
//    {
//        Console.WriteLine("choose option: ");
//        choice = Convert.ToInt32(Console.ReadLine());

//        switch(choice)
//        {
//            case '1':
//                Console.WriteLine("hello");
//                break;
//            case '2':
//                Console.WriteLine("good day");
//                break;
//            case '3':
//                Console.WriteLine("goodbye");
//                break;
//            default:
//                Console.WriteLine("wrong choice");
//                break;
//        }
//    }

//    catch(FormatException)
//    {
//        Console.WriteLine("please enter correct value: ");
//    }



//problem8:sum of even number only
//using System.Diagnostics.CodeAnalysis;

//Console.Write("Enter positive number:");
//int num=Convert.ToInt32(Console.ReadLine());
//int tot = 0;
//for (int x=1;x<=num;x++)
//{
//    if(x%2==0)
//    {
//        tot += x;
//    }
//}
//problem9:valideted positive input
//int num = 0;
//bool valideted = false;
//do
//{
//    try
//    {
//        Console.Write("Enter positive integer: ");
//        num = Convert.ToInt32(Console.ReadLine());
//        if (num > 0)
//        {
//            valideted = true;
//        }

//        else
//        {
//            Console.WriteLine("invalid input ");

//        }
//    }



//    catch (FormatException)
//    {
//        Console.WriteLine("please enter a correct number :");
//    }

//}

//while (!valideted);
//    int tot = 0;
//    for (int x = 1; x <= num; x++)
//    {
//        tot += x;
//    }
//    Console.WriteLine("the total  is: " + tot);







////problem:10:ATM machine simulation
//using System.Xml.Serialization;

//int pincorrect = 1234;
//double balance = 100.000;
//int numofattempt = 0;
//bool login = false;
//while (numofattempt < 3 && !login)
//{
//    try
//    {
//        Console.Write("enter a pin:");
//        int pin = Convert.ToInt32(Console.ReadLine());

//        if(pin==pincorrect)
//        {
//            login = true;
//        }
//        else
//        {
//            numofattempt++;
//            Console.WriteLine("Wrong pin");
//        }
//    }

//    catch(FormatException)
//    {
//        numofattempt++;
//        Console.WriteLine("invalid pin");
//    }
//}
//if(!login)
//{
//    Console.WriteLine("your card is blocked");
//    return;


//}
//int choice = 0;
//while (choice != 4)
//{
//    Console.WriteLine("menu");
//    Console.WriteLine("deposit");
//    Console.WriteLine("check balance");
//    Console.WriteLine("withdraw");
//    Console.WriteLine("exit");

//    try
//    {
//        Console.Write("select option: ");
//        choice = Convert.ToInt32(Console.ReadLine());
//        switch (choice)
//        {
//            case 1:
//                Console.Write("Enter the deposit amount: ");
//                double deposit = Convert.ToDouble(Console.ReadLine());

//                if (deposit > 0)
//                {
//                    balance += deposit;
//                    Console.WriteLine("your balance is " + balance);
//                }
//                else
//                {
//                    Console.WriteLine("amount not correct ");

//                }
//                break;
//            case 2:
//                Console.Write("Enter the withdrawal amount: ");
//                double withdraw = Convert.ToDouble(Console.ReadLine());
//                if (withdraw <= 0)
//                {
//                    Console.WriteLine("incorrect amount");

//                }
//                else if (withdraw > balance)
//                {
//                    Console.WriteLine("balance is not enough");
//                }

//                else
//                {
//                    balance -= withdraw;
//                    Console.WriteLine("your balance is: " + balance);

//                }
//                break;
//            case 3:
//                Console.WriteLine("thank you for using our serivce");
//                break;
//            default:
//                Console.WriteLine("please select option");
//                break;
//        }
//    }

//    catch(FormatException)
//    {
//        Console.WriteLine("input not correct");
//    }

//        }
    


        
    












