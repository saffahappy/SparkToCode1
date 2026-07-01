using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
////Task 1:PesonaL Infomration
//string Name = "Noor";
//double Height = 1.25;
//int Age = 20;
//bool isStudent = true;

//Console.WriteLine("my name is  " + Name);
//Console.WriteLine("im  " + Age+ " years old");
//Console.WriteLine("im  " + Height+ " cm");
//Console.WriteLine(" Im student : " + isStudent);
///////////////////////////////////////////////////////////////////////////////////////////
//Task2:calculating space of rectengle
//Console.WriteLine("Enter lenght: ");
//int length = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter width: ");
//int width = int.Parse(Console.ReadLine());
//int area = length * width;
//int perimeter = 2 * (length * width);
//Console.WriteLine();
//Console.WriteLine("result:");
//Console.WriteLine("the Area is : "+area +"cm");
//Console.WriteLine("the perimeter is:" +perimeter);

////////////////////////////////////////////////////////////////////////////////////////////////////
//task3:finding even number
//Console.Write("Enter a num: ");
//int num = int.Parse(Console.ReadLine());
//if (num % 2==0)
//{
//    Console.WriteLine("the number " + num + " is an even number");
//}
//else if(num %2 !=0)
//{
//    Console.WriteLine("the number " + num + " is odd number");
//}
/////////////////////////////////////////////////////////////////////////////////////////////////
//task 4:voting eligiility 
//Console.Write("please enter your age:");
//int age=int.Parse(Console.ReadLine());
//Console.Write("do you have your ID? :");
//string ans = Console.ReadLine();

//bool hasID;
//if (ans == "yes") 
//{
//    hasID= true;
//}
//else
//{
//    hasID = false;
//}


//if (age >= 18 && hasID==true) 
//{
//    Console.WriteLine("you are eligible");
//}
//else
//{
//    Console.WriteLine("you are not eligible ");
//}
/////////////////////////////////////////////////////////////////
//task5:looking up grade letter 
//Console.WriteLine("Enter your grade: ");
//char grade = Convert.ToChar(Console.ReadLine().ToUpper());

//switch(grade)
//{
//    case 'a':
//        Console.WriteLine("excellent");
//        break;

//    case 'b':
//        Console.WriteLine("very good");
//        break;

//    case 'c':
//        Console.WriteLine(" good");
//        break;

//    case 'd':
//        Console.WriteLine(" pass");
//        break;

//    case 'f':
//        Console.WriteLine(" fail");
//        break;

//    default:
//        Console.WriteLine("invalid");
//        break;
/////////////////////////////////////////////////////////////////////////////
//task6:Tempreture converter to fehernite

//Console.WriteLine("enter temp: ");
//float cel = float.Parse(Console.ReadLine());
//float fah = (cel * 9 / 5) + 32;
//Console.WriteLine();
//Console.WriteLine("tempreture in fahrenheit is "+ fah);

//if (cel < 10)
//{
//    Console.WriteLine("weather is cold ");
//}

//else if (cel<=30)
//{
//    Console.WriteLine("weather is mild ");

//}

//else
//{
//    Console.WriteLine("weather is hot ");
//}
[//task 7:movie ticket pricing 
//Console.WriteLine("enter your age: ");
//int age=int.Parse(Console.ReadLine());
//if (age>=0 && age<=12)
//{
//    Console.WriteLine("category is child ");
//    Console.WriteLine("price of ticket is 2 OMR ");

//}
//else if (age>=13] && age<=59)
//{
//    Console.WriteLine("category is adult ");
//    Console.WriteLine("price of ticket is 5 OMR ");
//}
//else
//{
//    Console.WriteLine("category is senior ");
//    Console.WriteLine("price of ticke is 3 OMR ");
//}
////////////////////////////////////////////////////////////////////////
//task8:Restaurant bill with discount 
//Console.WriteLine("enter the amount of bill:");
//float bill =float.Parse(Console.ReadLine());
//Console.Write("are a loyal member?:");
//string ans=Console.ReadLine();
//bool ismember;
//if (ans == "yes") 
//{
//    ismember = true;
//}
//else
//{
//    ismember= false;
//}
//Double dis = 0;
//Double finalbill = bill;
//if(bill>20 && ismember)
//{
//    dis = bill * 0.15;
//    finalbill = bill - dis;


//}
//Console.WriteLine();
//Console.WriteLine("the bill is "+bill);
//Console.WriteLine("your discount is "+ dis);
//Console.WriteLine("you final bill is "+bill);
////////////////////////////////////////////////////////////////
//task9:Day name finder system:
//Console.WriteLine("enter a number: ");
//int day=int.Parse(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("sunday");
//        break;
//    case 2:
//        Console.WriteLine("monday");
//        break;
//    case 3:
//        Console.WriteLine("tuesday");
//        break;
//    case 4:
//        Console.WriteLine("wednesday");
//        break;
//    case 5:
//        Console.WriteLine("thursday");
//        break;
//    case 6:
//        Console.WriteLine("friday");
//        break;
//    case 7:
//        Console.WriteLine("saturday");
//        break;
//    default:
//        Console.WriteLine("invalid ");
//        break;
//}
///////////////////////////////////////////////////////////////////

//task10:Mini Calculator system program
//Console.Write("enter your first number:");
//double num1=double.Parse(Console.ReadLine());

//Console.Write("enter your second number:");
//double num2 = double.Parse(Console.ReadLine());

//Console.Write("enter operator you are going to use :");
//char op = Convert.ToChar(Console.ReadLine());
//switch (op)
//{
//    case '-':
//        Console.WriteLine("result is " + (num1 - num2));
//        break;

//    case '+':
//        Console.WriteLine("result is " + (num1 + num2));
//        break;
//    case '*':
//        Console.WriteLine("result is " + (num1 * num2));
//        break;

//    case '/':
//        if(num2 !=0)
//        {
//            Console.WriteLine("the result is " +(num2 - num1));
//        }

//        else
//        {
//            Console.WriteLine("cant be divided by zero");
//        }

//        break;

//    default:
//        Console.WriteLine("invalid");
//        break;
//}

//////////////////////////////////////////////////////////////////
////task11:Loan eligbility system
//Console.Write("enter your age: ");
//int age = int.Parse(Console.ReadLine());

//Console.Write("enter your income: ");
//double income = double.Parse(Console.ReadLine());

//Console.Write("do you have a loan: ");
//string ans = Console.ReadLine();
//bool hasloan;
//if (ans == "yes")
//{
//    hasloan = true;
//}

//else
//{
//    hasloan = false;
//}

//if (age >= 21 && age <= 60 && income >= 400 && hasloan)
//{
//    Console.WriteLine("you are eligible");
//}
//else
//{
//    Console.WriteLine("you are not eligible");

//}

//if (age < 21 || age > 60)
//{
//    Console.WriteLine("age is not suitable");

//}

//if (income < 400)
//{
//    Console.WriteLine("your income is low ");

//}

//if (hasloan)
//{
//    Console.WriteLine("you already have loan");

//}

///////////////////////////////////////////////////////
//task12:Shipping cost calculator
//        Console.Write("Enter your code: ");
//        char region = Convert.ToChar(Console.ReadLine().ToUpper());
//        Console.Write("Enter your package weight: ");
//        float weight = float.Parse(Console.ReadLine());
//        double cost = 0;
//        double extra = 0;

//        switch (region)
//        {
//            case 'A':
//                cost = 1.000;
//                break;

//            case 'B':
//                cost = 3.000;
//                break;
//            case 'C':
//                cost = 7.000;
//                break;
//            default:
//                Console.WriteLine("invalid region");
//                return; 

//}
//if (weight>10)
//        {
//            extra = 5.000;
//        }
//else if(weight>5)
//        {
//            extra = 2.000;
//        }
//        double total = cost + extra;

//        Console.WriteLine();
//        Console.WriteLine("the base cost is "+cost);
//        Console.WriteLine("the extra charge is " +extra);
//        Console.WriteLine("the total cost is "+cost);
//////////////////////////////////////////////////////////////////
////task13:triangle type classifier system:
//Console.Write("enter the number of first side:");
//double side1 = double.Parse(Console.ReadLine());

//Console.Write("enter the number of second side:");
//double side2 = double.Parse(Console.ReadLine());

//Console.Write("enter the number of third side:");
//double side3 = double.Parse(Console.ReadLine());

//if (side2 + side3 > side1 && side1 + side2 > side3 && side1 + side3 >
//        side2)
//{
//    Console.WriteLine("valid traingle");


//    if (side2 == side3 && side1 == side2)
//    {
//        Console.WriteLine("the type is Equilateral");
//    }

//    else if (side1 == side3 && side2 == side3 && side1 == side2)
//    {
//        Console.WriteLine("the type is Isosceles");

//    }

//    else
//    {
//        Console.WriteLine("the type is Scalene");

//    }
//}

//else
//{
//    Console.WriteLine("the sides dont form a traingle");

//}

//task14
//Console.Write("Enter the code: ");
//int code = int.Parse(Console.ReadLine());

//Console.Write("Enter the quanity: ");
//int quanity = int.Parse(Console.ReadLine());

//Console.Write("do you have a coupon: ");
//string answer = Console.ReadLine();
//bool hascoupon;
//if (answer == "yes")

//{ hascoupon = true;

//}


//else
//{
//    hascoupon = false;
//}
//string proname = "";
//double priceunit = 0;

//    switch (code)
//    {
//        case 1:
//            proname = "headphones";
//            priceunit = 8.500;
//            break;

//        case 2:
//            proname = "keyboard";
//            priceunit = 12.000;
//            break;

//        case 3:
//            proname = "mouse";
//            priceunit = 5.000;
//            break;

//        default:
//            Console.WriteLine("invalid code");
//            return;
    
//    }

//double total = priceunit * quanity;
//double discount = 0;
//if(hascoupon && total >20)
//{
//    discount = total * 0.10;
//}

//double amountdiscounted = total - discount;
//double tax = amountdiscounted * 0.05;
//double finaltotal = amountdiscounted + tax;

//Console.WriteLine();
//Console.WriteLine("the product is "+proname);
//Console.WriteLine("the subtotal is "+total);
//Console.WriteLine("the discount is "+discount);
//Console.WriteLine("the tax is "+tax);
//Console.WriteLine("the total is "+finaltotal);

//task 15



























