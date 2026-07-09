//Q1:fixed Grades array
//internal class Program
//{
//    static void Main(string[]args)
//    {
//        int[] grades = new int[5];
//        for(int i = 0; i < grades.Length; i++)
//        {
//            Console.Write("Enter a grade: " + (i + 1));
//            grades[i] =Convert.ToInt32(Console.ReadLine());

//        }

//        Console.WriteLine("grades;");
//        {
//            Console.WriteLine(grades);
//        }
//    }
//}

//Q2:To Do list
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> tasks = new List<string>();
//        for (int i = 0;i<5;i++)
//        {
//            Console.Write("enter a task"+(i+1));
//            string task=Console.ReadLine();
//            tasks.Add(task);
//        }
//        Console.WriteLine("to do list");

//        foreach (string task in list);
//        {
//            Console.WriteLine("" + tasks);
//        }

//    }
//}

//Q3:browsing history stack:
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Stack<string> history = new Stack<string>();
//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write("enter website:");
//            string web = Console.ReadLine();

//            history.Push(web);
//        }
//        Console.WriteLine();
//        string page = history.Pop();
//        Console.WriteLine("you went back");
//        Console.WriteLine("current page" + page);
//        Console.WriteLine("left page: " + history.Peek());
//    }

//Q4:customer service
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Queue<string> customer=new Queue<string>();
//        for(int i=0; i<3; i++)
//        {
//            Console.Write("enter name:");
//            string name=Console.ReadLine();

//            customer.Enqueue(name);
//        }
//        Console.WriteLine();
//        string customer = customers.Deqeue();
//        Console.WriteLine("customer is served: "+customer);
//        Console.WriteLine("remaininng customers:");
//        foreach (string name in customer)
//        {
//            Console.WriteLine($"{name}");
//        }




//    }
////Q5:grade range:
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] grades = new int[5];
//        int sum = 0;
//        for (int i = 0; i < grades.Length; i++)
//        {
//            Console.WriteLine("enter grade" + (i + 1) + ":");
//            grades[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        Array.Sort(grades);
//        for (int i = 0; i < grades.Length; i++)
//        {
//            sum += grades[i];
//        }
//        double average = ((double)sum) / grades.Length;
//        Console.WriteLine("high grade" + grades[grades.Length - 1]);
//        Console.WriteLine("low grade" + grades[0]);
//        Console.WriteLine("average" + average);
//    }


//    }

//Q6:shopping list


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<string> shoppingList = new List<string>();

//        while (true)
//        {
//            Console.Write("Enter an item (or type done): ");
//            string item = Console.ReadLine();

//            if (item.ToLower() == "done")
//            {
//                break;
//            }

//            shoppingList.Add(item);
//        }

//        Console.WriteLine("\nShopping List:");

//        foreach (string item in shoppingList)
//        {
//            Console.WriteLine(item);
//        }

//        Console.Write("Enter an item to remove: ");
//        string removeItem = Console.ReadLine();

//        shoppingList.Remove(removeItem);

//        Console.WriteLine("\nShopping List After Removal:");

//        foreach (string item in shoppingList)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//Q7:high score


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> scores = new List<int>();

//        for (int i = 0; i < 5; i++)
//        {
//            Console.Write("Enter score " + (i + 1) + ": ");
//            int score = Convert.ToInt32(Console.ReadLine());

//            scores.Add(score);
//        }

//        scores.Sort();
//        scores.Reverse();

//        Console.WriteLine("Top 3 Scores");
//        Console.WriteLine("1st : " + scores[0]);
//        Console.WriteLine("2nd : " + scores[1]);
//        Console.WriteLine("3rd: " + scores[2]);
//    }
//}

//Q8:undo last acttion


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Stack<string> actions = new Stack<string>();

//        while (true)
//        {
//            Console.Write("Enter an action (or type stop): ");
//            string action = Console.ReadLine();

//            if (action.ToLower() == "stop")
//            {
//                break;
//            }

//            actions.Push(action);
//        }

//        Console.WriteLine("Undo 1: " + actions.Pop());
//        Console.WriteLine("Undo 2: " + actions.Pop());

//        Console.WriteLine("Remaining Actions:");

//        foreach (string action in actions)
//        {
//            Console.WriteLine(action);
//        }
//    }
//}
////Q9:grade analyse function


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> grades = new List<int>();

//        Console.Write("How many grades do you want to enter? ");
//        int number = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < number; i++)
//        {
//            Console.Write("Enter grade " + (i + 1) + ": ");
//            int grade = Convert.ToInt32(Console.ReadLine());

//            grades.Add(grade);
//        }

//        double average = CalculateAverage(grades);
//        int failingGrade = FindFirstFailing(grades);

//        Console.WriteLine("Average = " + average);

//        if (failingGrade == 0)
//        {
//            Console.WriteLine("No failing grades.");
//        }
//        else
//        {
//            Console.WriteLine("First failing grade = " + failingGrade);
//        }
//    }

//    static double CalculateAverage(List<int> grades)
//    {
//        int sum = 0;

//        for (int i = 0; i < grades.Count; i++)
//        {
//            sum += grades[i];
//        }

//        return (double)sum / grades.Count;
//    }

//    static int FindFirstFailing(List<int> grades)
//    {
//        return grades.Find(x => x < 60);
//    }
//}
//Q10:print manager


//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Queue<string> printQueue = new Queue<string>();

//        while (true)
//        {
//            Console.Write("Enter print job (or type done): ");
//            string job = Console.ReadLine();

//            if (job.ToLower() == "done")
//            {
//                break;
//            }

//            printQueue.Enqueue(job);
//        }

//        Console.WriteLine("\nCurrent Print Queue:");

//        foreach (string job in printQueue)
//        {
//            Console.WriteLine(job);
//        }

//        Console.Write("\nEnter the job name to cancel: ");
//        string cancelJob = Console.ReadLine();

//        printQueue = RemoveJob(printQueue, cancelJob);

//        Console.WriteLine("\nPrint Queue After Cancellation:");

//        foreach (string job in printQueue)
//        {
//            Console.WriteLine(job);
//        }
//    }

//    static Queue<string> RemoveJob(Queue<string> printQueue, string cancelJob)
//    {
//        Queue<string> newQueue = new Queue<string>();

//        while (printQueue.Count > 0)
//        {
//            string currentJob = printQueue.Dequeue();

//            if (currentJob != cancelJob)
//            {
//                newQueue.Enqueue(currentJob);
//            }
//        }

//        return newQueue;
//    }
//}


