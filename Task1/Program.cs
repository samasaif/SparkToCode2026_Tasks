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
        
        // Task 4 - Voting Eligibility
        Console.WriteLine("enter your age: ");
        int ageNum = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("do you hold a valid national ID?(yes/no): ");
        string nationalID = Console.ReadLine();
        
        bool hasID = nationalID == "yes";

        if (hasID && ageNum >= 18)
        {
            Console.WriteLine("the person is eligible to vote");
        }
        else
        {
            Console.WriteLine("the person is NOT eligible to vote");
        }
        Console.Write("\n");
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Task 5 - Grade Letter Lookup
        Console.WriteLine("enter a single character representing your grade ('A', 'B', 'C', 'D', or 'F'):");
        char grade = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (grade)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;


            case 'B':
                Console.WriteLine("Very Good");
                break;


            case 'C':
                Console.WriteLine("Good");
                break;

            case 'D':
                Console.WriteLine("Pass");
                break;
            
            case 'F':
                Console.WriteLine("Fail");
                break;
            
            default:
                Console.WriteLine("please choose a correct option");
                break;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Task 6 - Temperature Converter
        Console.WriteLine("enter the temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
        if (celsius < 10)
        {
            Console.WriteLine("weather is Cold");
        }
        else if (celsius <= 30)
        {
            Console.WriteLine("weather is Mild");
        }
        else
        {
            Console.WriteLine("weather is Hot");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        
    }
    
}