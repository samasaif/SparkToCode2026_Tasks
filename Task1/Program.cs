namespace Task1;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Personal Info Card
        string name = "Sama";
        int age = 22;
        double heightInMeters = 1.61;
        bool isStudent = true;
        
        Console.Write("Name: " + name + ", Age: " + age + ", Height: " + heightInMeters + ", Student: " + isStudent);
        Console.Write("\n");
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Task 2 - Rectangle Calculator
        Console.WriteLine("enter length: ");
        float length = float.Parse(Console.ReadLine());
        
        Console.WriteLine("enter width: ");
        float width = float.Parse(Console.ReadLine());
        
        float area = length * width;
        float perimeter = 2 * (length + width);
        
        Console.WriteLine("The area is: " + area);
        Console.WriteLine("The perimeter is: " + perimeter);
        Console.Write("\n");
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 3 - Even or Odd Checker
        Console.WriteLine("enter a whole number: ");
        int wholeNumber = Convert.ToInt32(Console.ReadLine());
        
        if  (wholeNumber % 2 == 0)
        { 
            Console.WriteLine("The number is EVEN");
        }
        else
        {
            Console.WriteLine("The number is ODD");
        }
        Console.Write("\n");
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        
    }
}