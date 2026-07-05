//probelm1:absoltue diffrence 
//Console.Write("enter your first num: ");
//double number1=Convert.ToDouble(Console.ReadLine());

//Console.Write("enter your send num: ");
//double number2 = Convert.ToDouble(Console.ReadLine());

//double differnce=Convert.ToDouble(Console.ReadLine());
//double difference = Math.Abs(number1 - number2);
//Console.WriteLine("the differnece of postitisve is: " + difference);

//problem:2the power and root exploere
//Console.Write("enter a number : ");
//double num = Convert.ToDouble(Console.ReadLine());

//double square = Math.Pow(num, 2);
//double squareRoot = Math.Sqrt(num);
//Console.WriteLine("the square is: " + square);
//Console.WriteLine("the square  root is: " + squareRoot);

//problem3:name format

//Console.Write("enter you name: ");
//string name=Console.ReadLine();
//Console.WriteLine("Lowercase name is: " + name.ToLower());
//Console.WriteLine("upper case  name is: " + name.ToUpper());
//Console.WriteLine("lenght of the name is : " + name.Length);

//problem:subscription end date
//Console.Write("Enter a free triale: ");
//int day=Convert.ToInt32(Console.ReadLine());
//DateTime endDate = DateTime.Today.AddDays(day);
//Console.WriteLine("your trial end on:" + endDate.ToString("d-m-y"));

//probelm5:grade system
//Console.Write("enter your score: ");
//double score = Convert.ToDouble(Console.ReadLine());
//double rounded =Math.Round(score);
//Console.WriteLine("the rounded score is :" + rounded);
//if (rounded >= 60)
//{
//    Console.WriteLine("you passed");
//}
//else
//{
//    Console.WriteLine("you failed");

//}

//problem6:password stringht checker
using System.ComponentModel;
using System.Linq.Expressions;

//Console.Write("enter password: ");
//string pass=Console.ReadLine();
//if(pass.Length>=8 && !pass.ToLower().Contains("password"))
//{
//    Console.WriteLine("your password is strong ");
//}
//else
//{
//    Console.WriteLine("your password is weak ");

//}

//{
//    Console.WriteLine("weak");
//    if(pass.Length<8)
//    {
//        Console.WriteLine("password is less then 8 digits");
//    }

//    if(pass.ToLower().Contains("password"))
//    {
//        Console.WriteLine("has the word password");
//    }
//}

//problem7:name operator
//Console.Write("enter forst name: ");
//string na1 = Console.ReadLine();

//Console.Write("enter seond  name: ");
//string na2 = Console.ReadLine();

//na1 = na1.Trim().ToUpper();
//na2 = na2.Trim().ToUpper();

//if(na1==na2)
//{
//    Console.WriteLine("the  names are same ");

//}

//else
//{
//    Console.WriteLine("the  names are not same ");


//}


//problem8:membership 
//try
//{
//    Console.WriteLine("membership start: ");
//    DateTime startDate = DateTime.Parse(Console.ReadLine());
//    Console.Write("enter number of days: ");
//    int days = Convert.ToInt32(Console.ReadLine());
//    DateTime expiryDate = startDate.AddDays(days);
//    if(expiryDate>=DateTime.Today)
//    {
//        Console.WriteLine("active");
//    }

//    else
//    {
//        Console.WriteLine("ended");
//    }

//    Console.WriteLine("the membership will expire: " + expiryDate.ToString("d-m-y"));

//}
//catch
//{
//    Console.WriteLine("input you entered is not correct");
//}



//problem9:rounding the  number 
//Console.Write("enter number: ");
//double number=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("the closest number: "+Math.Round(number));
//Console.WriteLine("the round down : " + Math.Floor(number));
//Console.WriteLine("the round up: " + Math.Ceiling(number));

//problem10:word finder
//Console.Write("Enter your sentences: ");
//string sentence=Console.ReadLine();
//Console.Write("Enter your word: ");
//string word = Console.ReadLine();

//if(sentence.Contains(word))
//{
//    Console.WriteLine("word first postions " + sentence.IndexOf(word));
//    Console.WriteLine("word seoncd postions " + sentence.LastIndexOf(word));

//}

//else
//{
//    Console.WriteLine("word not found");
//}



//problem11:OTP
//Random random = new Random();
//int otp = random.Next(1000, 10000);
//Console.WriteLine("the OTP is: " + otp);
//int atempt = 0;
//while (atempt <3)
//{
//    try
//    {
//        Console.Write("enter otp: ");
//        int otp2 = Convert.ToInt32(Console.ReadLine());
//        if (otp2 == otp)
//        {
//            Console.WriteLine("the user is verified");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("the user is not verified");

//        }
//    }
//    catch
//    {
//        Console.WriteLine("incorrect input ");

//    }
//    atempt++;
//    if (atempt == 3)
//    {
//        Console.WriteLine("failed");
//    }
//}




//problem12:insights of birthday
//try
//{
//    Console.Write("enter birthday: ");
//    DateTime birthday = DateTime.Parse(Console.ReadLine());
//    int age = DateTime.Today.Year - birthday.Year;
//    if (DateTime.Today.Month < birthday.Month || (
//        DateTime.Today.Month == birthday.Month &&
//        DateTime.Today.Day < birthday.Day))
//    {
//        age--;
//    }
//    Console.WriteLine("the age is :" + age);
//    Console.WriteLine("birthday date is  :" + birthday.DayOfWeek);

//}

//catch
////{
////    Console.WriteLine("wring date");
//}


