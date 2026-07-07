////Q1:Welcome function
//using System.Xml.Linq;
//Console.Write("please enter you name: ");
//string name1 = Console.ReadLine();

//Console.WriteLine($"welcome,{name1} we are happy to see");
//Console.WriteLine("enjoy your time learning");
/////////////////////////////////////////////////////////////////////////////////////////////////
/////Q2:Square number:

//internal class Program
//{
//    private static int Main(string[] args)
//    {
//        Console.Write("enter a number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());
//        int asn = Square(num1);
//        Console.WriteLine("the square is " + asn);
//        int res = num1 * num1;
//        return res;
//    }

//    private static int Square(int num1)
//    {
//        // return the square of the input
//        return num1 * num1;
//    }
//}
///////////////////////////////////////////////////////////////////////////////


//Q3:Celsuice and faharnite
//internal class Program
//{
//    static double CelsiusToFahrenheit(double celsius)
//    {
//        double fahrenheit = (celsius * 9 / 5) + 32;
//        return fahrenheit;
//    }

//    static void Main(string[]args)
//    {
//        Console.Write("tempreture in celsuis: ");
//        double celsius = Convert.ToDouble(Console.ReadLine());
//        double res=CelsiusToFahrenheit(celsius);
//        Console.WriteLine($"tempreture in fahrenheit is: {res} ");
//    }

//}
//////////////////////////////////////////////////////////////////////////////////
//Q4:menu display
//internal class Program
//{
//    static void DisplayMenu()
//    {
//        Console.WriteLine("Menu:");
//        Console.WriteLine("1. start");
//        Console.WriteLine("2. help");
//        Console.WriteLine("3. exit");
//    }
//    static void Main(string[] args)
//    {
//        DisplayMenu();
//    }
//}
///////////////////////////////////////////////////////////////////////////////////
//Q5:odd or even fucntion
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("enter a number: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        if (IsEven(num))
//        {
//            Console.WriteLine($"{num} is even");
//        }
//        else
//        {
//            Console.WriteLine($"{num} is odd");
//        }
//    }
//    static bool IsEven(int number)
//    {
//        return number % 2 == 0;
//    }
//}
////////////////////////////////////////////////////////////////////////
//Q6:rectegale and premiter 
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("rectangle lenght: ");
//        double length = Convert.ToDouble(Console.ReadLine());
//        Console.Write("rectangle width: ");
//        double width = Convert.ToDouble(Console.ReadLine());
//        double area = CalculateArea(length, width);
//        double perimeter = CalculatePerimeter(length, width);
//        Console.WriteLine($"rectengale area: {area}");
//        Console.WriteLine($"Perimeter: {perimeter}");
//    }
//    static double CalculateArea(double length, double width)
//    {
//        return length * width;
//    }
//    static double CalculatePerimeter(double length, double width)
//    {
//        return 2 * (length + width);
//    }
//}
////////////////////////////////////////////////////////////////////////////////
////Q7:grade letter
//internal class Program
//{
//    static string GetGradeLetter(int score)
//    {
//        if (score >= 90)
//        {
//            return "A";
//        }
//        else if (score >= 80)
//        {
//            return "B";

//        }
//        else if (score >= 70)
//        {
//            return "C";

//        }
//        else if (score >= 60)
//        {
//            return "D";

//        }
//        else
//        {
//            return "F";

//        }

//    }

//    static void Main(string[] args)
//    {
//        Console.Write("your score: ");
//        int score1 = Convert.ToInt32(Console.ReadLine());
//        string grade = GetGradeLetter(score1);
//        Console.WriteLine("your final grade is " + grade);
//    }
//}
//////////////////////////////////////////////////////////////////////////
//Q8:Countdown function
//internal class Program
//{
//    static void Countdown(int number)
//    {
//        for (int x = number; x >= 1; x--)
//        {
//            Console.WriteLine(x);
//        }

//    }
//    static void Main(string[] args)
//    {
//        Console.Write("enter a number: ");
//        int number = Convert.ToInt32(Console.ReadLine());
//        Countdown(number);
//    }
//}
//////////////////////////////////////////////////////////////////////////////////////////////////////
//Q9:Overloaded fucntion
using System.Numerics;

//internal class program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("multiply the numbers: " + Mulitply(5, 4));
//        Console.WriteLine("multiply in double : " + Mulitply(2.5,3.5));
//        Console.WriteLine("multiply integers: " + Mulitply(2, 4, 3));


//    }

//    static int Mulitply(int num1,int num2)
//    {
//        return num1 * num2;
//    }
//    static double Mulitply(double num1, double num2)
//    {
//        return num1 * num2;
//    }
//    static int Mulitply(int num1, int num2,int num3)
//    {
//        return num2 * num1*num3;
//    }




//}

//////////////////////////////////////////////////////////////////////

//Q10:Area calculator
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("select a shape: ");
//        Console.WriteLine("square: ");
//        Console.WriteLine("circle:");

//        int choice = Convert.ToInt32(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.Write("enter side");
//            double side = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("the area is:" + CalculateArea(side));
//        }
//        else if (choice == 2)
//        {
//            Console.Write("Enter the lenght:**");
//            double lenght = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Enter the width:**");
//            double width = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("area:" + CalculateArea(lenght, width));
//        }
//        else
//        {
//            Console.WriteLine("wrong choice");
//        }
//    }

//        static double CalculateArea(double side)
//        {
//            return side * side;
//        }

//        static double CalculateArea(double length, double width)
//        {
//            return length * width;
//        }
//    }




////////////////////////////////////////////////////////////////////////////////////////
//Q11:calculator based fucntion
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        bool run = true;
//        while (run)
//        {
//            Console.WriteLine("substract");
//            Console.WriteLine("add");
//            Console.WriteLine("multioly");
//            Console.WriteLine("divide");
//            Console.WriteLine("exit");

//            Console.Write("select an option: ");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            if (choice == 5)
//            {
//                run = false;
//                break;
//            }
//            Console.Write("enter number: ");
//            double num1 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("enter secondnumber: ");
//            double num2 = Convert.ToDouble(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    DisplayResult("the result of substract:", Substract(num1, num2));
//                    break;
//                case 2:
//                    DisplayResult("the result of addition:", Add(num1, num2));
//                    break;
//                case 3:
//                    DisplayResult("the result of multiplicaion:", MultiplyNumbers(num1, num2));
//                    break;

//                case 4:
//                    DisplayResult("the result of division:", DivideNumbers(num1, num2));
//                    break;
//                default:
//                    Console.WriteLine("wrong choice");

//                    break;





//            }
//            Console.WriteLine();



//        }
//    }
//    static double Substract(double num1, double num2)
//    {
//        return num1 - num2;
//    }

//    static double Add(double num1, double num2)
//    {
//        return num1 + num2;
//    }
//    static double MultiplyNumbers(double num1, double num2)
//    {
//        return num1 * num2;
//    }
//    static double DivideNumbers(double num1, double num2)
//    {
//        try
//        {
//            if (num2 == 0)
//            {
//                throw new DivideByZeroException();
//            }
//            return num1 / num2;
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("cant be didivded");
//            return double.NaN; // ensure all paths return a double
//        }
//    }
//    static void DisplayResult(string operation, double result)
//    {
//        Console.WriteLine(operation + "result" + result);
//    }
//}





//Q12:student report generator 
using System;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("enter student name: ");
//        string name = Console.ReadLine();
//        Console.Write("enter first score: ");
//        double score1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("enter second number: ");
//        double score2 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("enter third number: ");
//        double score3 = Convert.ToDouble(Console.ReadLine());

//        double ave = CalculateAverage(score1, score2, score3);

//        string grade = GetGradeLetter(ave);
//        PrintReportCard(name, ave, grade);
//    }

//    static double CalculateAverage(double score1, double score2, double score3)
//    {
//        return (score1 + score2 + score3) / 3;
//    }

//    static string GetGradeLetter(double ave)
//    {
//        if (ave >= 90)
//        {
//            return "A";
//        }
//        else if (ave >= 80)
//        {
//            return "B";
//        }
//        else if (ave >= 70)
//        {
//            return "C";
//        }
//        else if (ave >= 60)
//        {
//            return "D";
//        }
//        else
//        {
//            return "F";
//        }
//    }

//    static void PrintReportCard(string name, double average, string grade)
//    {
//        Console.WriteLine();
//        Console.WriteLine("report card details");
//        Console.WriteLine("the name of student: " + name);
//        Console.WriteLine("average: " + average);
//        Console.WriteLine("the grade is: " + grade);
//    }
//}







