namespace Task5;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Fixed Grades Array
        /*
        int[] grades = new int[5];

        for (int i = 0; i < grades.Length; i++)
        {
            bool valid = false;
            while (!valid)
            {
                try
                {
                    Console.Write("enter grade " + (i + 1) + " : ");
                    grades[i] = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input... Please enter an integer");
                }
            }
        }
        Console.WriteLine("\nGrades:");
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        */
        /////////////////////////////////////////////////////////////////////////////////////
        
        // Task 2 - Dynamic To-Do List
        /*
        List<string> tasks = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("enter a task " + (i + 1) + " : ");
            tasks.Add(Console.ReadLine());
        }
        Console.WriteLine("\nTasks:");
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }*/
        /////////////////////////////////////////////////////////////////////////////////////
        
        // Task 3 - Browsing History Stack
        /*
        Stack<string> history = new Stack<string>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("enter a website URL " + (i + 1) + " : ");
            history.Push(Console.ReadLine());
        }

        history.Pop();
        Console.WriteLine("page: " + history.Peek());
        */
        /////////////////////////////////////////////////////////////////////////////////////
        
        // Task 4 - Customer Service Queue
        /*
        Queue<string> customers = new Queue<string>();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter customer name: " + (i + 1) + " : ");
            customers.Enqueue(Console.ReadLine());
        }
        
        Console.WriteLine("serving: " + customers.Dequeue());
        */
        /////////////////////////////////////////////////////////////////////////////////////
        
        // Task 5 - Array Grade Range
        int[] grades1 = new int[5];
        double sum = 0;
        int highestGrade = 0;
        int lowestGrade = 0;

        for (int i = 0; i < grades1.Length; i++)
        {
            bool valid = false;
            while (!valid)
            {
                try
                {
                    Console.Write("enter grade " + (i + 1) + " : ");
                    grades1[i] = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input... Please enter an integer");
                }
            }
        }
        // initialize the highest and lowest value with the first grade in the array 
        highestGrade = grades1[0];
        lowestGrade = grades1[0];
        
        for (int i = 0; i < grades1.Length; i++)
        {
            sum += grades1[i];
            
            grades1.Sort();
            if (grades1[i] > highestGrade)
            {
                highestGrade = grades1[i];
            }

            if (grades1[i] < lowestGrade)
            {
                lowestGrade = grades1[i];
            }
        }
        double averageGrade = sum / grades1.Length;
        Console.WriteLine("\nThe average of the grades is: " + averageGrade);
        Console.WriteLine("The highest grades is: " + highestGrade);
        Console.WriteLine("The lowest grades is: " + lowestGrade);
        /////////////////////////////////////////////////////////////////////////////////////

        
        
    }
}