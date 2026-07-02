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
        
        // Task 7 - Movie Ticket Pricing
        Console.Write("please enter your age: ");
        int ageN = Convert.ToInt32(Console.ReadLine());

        if (ageN >= 0 && ageN <= 12)
        {
            Console.WriteLine("Category: Children");
            Console.WriteLine("Ticket Price = 2.000 OMR");
        }
        else if (ageN >= 13 && ageN <= 59)
        {
            Console.WriteLine("Category: Adults");
            Console.WriteLine("Ticket Price = 5.000 OMR");
        }
        else
        {
            Console.WriteLine("Category: Seniors");
            Console.WriteLine("Ticket Price = 3.000 OMR");
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Task 8 - Restaurant Bill with Membership Discount
        Console.Write("please enter your total bill amount: ");
        double billAmount = double.Parse(Console.ReadLine());
        
        Console.Write("are you a loyalty member? (yes/no): ");
        string loyal = Console.ReadLine();

        bool isMember = loyal.ToLower() == "yes";

        double discount = 0 ;
        if (isMember && billAmount > 20)
        { 
            discount = billAmount * 0.15;
        } 
        double amount = billAmount - discount;
        
        Console.WriteLine("original bill: " + billAmount);
        Console.WriteLine("discount amount: " + discount);
        Console.WriteLine("final amount: " + amount);
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        Console.WriteLine("\n");
        // Task 9 - Day Name Finder
        
        Console.WriteLine("enter a number from 1 to 7 representing a day of the week: ");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;
            
            case 4:
                Console.WriteLine("Wednesday");
                break;
            
            case 5:
                Console.WriteLine("Thursday");
                break;
            
            case 6:
                Console.WriteLine("Friday");
                break;
            
            case 7:
                Console.WriteLine("Saturday");
                break;

            default:
                Console.WriteLine("Invalid day number");
                break;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
    
}