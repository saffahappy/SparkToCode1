////Q1 fixed grade array
//using System;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] grades = new int[5];

//        for (int i = 0; i < grades.Length; i++)
//        {
//            Console.Write("Enter grade " + (i + 1));
//            grades[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        Console.WriteLine("Student Grades:");

//        foreach (int grade in grades)
//        {
//            Console.WriteLine(grade);
//        }
//    }
//}

////Q2:Dynamic to do list 
//using System;
//using System.Collections.Generic;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> tasks = new List<string>();

//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write("Enter task " + (i + 1));
//            string task = Console.ReadLine();

//            tasks.Add(task);
//        }

//        Console.WriteLine("list:");

//        foreach (string task in tasks)
//        {
//            Console.WriteLine("- " + task);
//        }
//    }
//}

////Q3:history stack
//using System;
//using System.Collections.Generic;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Stack<string> history = new Stack<string>();

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write("Enter website URL: ");
//            string website = Console.ReadLine();

//            history.Push(website);
//        }

//        Console.WriteLine();

//        string removedPage = history.Pop();

//        Console.WriteLine("You went  Back.");
//        Console.WriteLine(" page: " + removedPage);

//        Console.WriteLine(" page: " + history.Peek());
//    }
//}

////Q4:CUSTOMER SERVICE LINE 
//using System;
//using System.Collections.Generic;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Queue<string> customers = new Queue<string>();

//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write("enter  name: ");
//            string name = Console.ReadLine();

//            customers.Enqueue(name);
//        }

//        Console.WriteLine();

//        string servedCustomer = customers.Dequeue();

//        Console.WriteLine("customer : " + servedCustomer);

//        Console.WriteLine("remaining customers:");

//        foreach (string customer in customers)
//        {
//            Console.WriteLine(customer);
//        }
//    }
//}

////Q5:grade range 
//using System;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] grades = new int[5];
//        int sum = 0;

//        for (int i = 0; i < grades.Length; i++)
//        {
//            Console.Write("Enter grade " + (i + 1) + ": ");
//            grades[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        Array.Sort(grades);

//        for (int i = 0; i < grades.Length; i++)
//        {
//            sum += grades[i];
//        }

//        double average = (double)sum / grades.Length;

//        Console.WriteLine("Low Grade: " + grades[0]);
//        Console.WriteLine("High Grade: " + grades[grades.Length - 1]);
//        Console.WriteLine("Average : " + average);
//    }
//}
