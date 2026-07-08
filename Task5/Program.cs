namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Fixed Grades Array
        int[] grades = new int[5];

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write("enter grade " + (i + 1) + " : ");
            grades[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nGrades:");
        foreach (int grade in grades)
        {
            Console.WriteLine(grade);
        }
        /////////////////////////////////////////////////////////////////////////////////////
    }
}