namespace Task4;

class Program
{
    //========================Main=============================================
    static void Main(string[] args)
    {
        // Task 1 - Personalized Welcome Function
        Console.Write("enter your name: ");
        string name = Console.ReadLine();
        WelcomMssg(name);
        ////////////////////////////////////////////////////////////////////////

        // Task 2 - Square Number Function
        Console.Write("enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("the square of " + number + " = " + SquareNum(number));
        ////////////////////////////////////////////////////////////////////////

        // Task 3 - Celsius to Fahrenheit Function
        Console.Write("enter temperature in celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = CelsiusToFahrenheit(celsius);
        Console.WriteLine("the temperature in fahrenheit is " + fahrenheit);
        ////////////////////////////////////////////////////////////////////////

        // Task 4 - Fixed Menu Display Function
        DisplayMenu();
        ////////////////////////////////////////////////////////////////////////

        // Task 5 - Even or Odd Function
        Console.Write("enter a number: ");
        int number2 = int.Parse(Console.ReadLine());
        if (IsEven(number2))
        {
            Console.WriteLine("The number is even");
        }
        else
            {
            Console.WriteLine("The number is odd");
            }
        ////////////////////////////////////////////////////////////////////////
        
        // Task 6 - Rectangle Area & Perimeter Functions
        Console.Write("enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("enter width: ");
        double width = double.Parse(Console.ReadLine());
        double perimeter = CalculatePerimeter(length, width);
        double area = CalculateArea(length, width);
        Console.WriteLine("The perimeter is: " + perimeter);
        Console.WriteLine("The area is: " + area);
        ////////////////////////////////////////////////////////////////////////

        // Task 7 - Grade Letter Function
        Console.Write("enter your score: ");
        int score = int.Parse(Console.ReadLine());
        string gradeLetter = GetGradeLetter(score);
        Console.WriteLine($"The score is {score} and the grade is {gradeLetter}");
        ////////////////////////////////////////////////////////////////////////
        
       // Task 8 - Countdown Function
       Console.Write("enter a starting number: ");
       int startNum = int.Parse(Console.ReadLine());
       Countdown(startNum);
       ////////////////////////////////////////////////////////////////////////
       
        

        
        
    }
    

    //========================Functions=============================================
    // Task 1 - Personalized Welcome Function
    static void WelcomMssg(string name)
    {
        Console.WriteLine($"Welcome {name}!");
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 2 - Square Number Function
    static int SquareNum(int number)
    {
        return number * number;
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 3 - Celsius to Fahrenheit Function
    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 4 - Fixed Menu Display Function
    static void DisplayMenu()
    {
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Help");
        Console.WriteLine("3) Exit");
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 5 - Even or Odd Function
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 6 - Rectangle Area & Perimeter Functions
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
    static double CalculatePerimeter(double length, double width)
    {
        return (length + width) * 2;
    }
    ////////////////////////////////////////////////////////////////////////
    
    // Task 7 - Grade Letter Function
    static string GetGradeLetter(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 8 - Countdown Function
    static void Countdown(int startNum)
    {
        for (int i = startNum; i >= 1; i--)
        {
            Console.WriteLine(i);
        } 
        Console.WriteLine("Liftoff!");
    }
    ////////////////////////////////////////////////////////////////////////
    
    

    
    
}