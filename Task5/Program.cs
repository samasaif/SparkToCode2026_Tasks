namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Fixed Grades Array
        
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
        
        /////////////////////////////////////////////////////////////////////////////////////
    }
}