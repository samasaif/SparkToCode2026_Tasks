namespace Task5;

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
        Stack<string> history = new Stack<string>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("enter a website URL " + (i + 1) + " : ");
            history.Push(Console.ReadLine());
        }

        history.Pop();
        Console.WriteLine("page: " + history.Peek());
    }
}