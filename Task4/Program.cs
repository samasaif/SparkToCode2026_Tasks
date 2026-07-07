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
        

    }

    //========================Functions=============================================
    // Task 1 - Personalized Welcome Function
    public static void WelcomMssg(string name)
    {
        Console.WriteLine($"Welcome {name}!");
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 2 - Square Number Function
    public static int SquareNum(int number)
    {
        return number * number;
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 3 - Celsius to Fahrenheit Function
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 4 - Fixed Menu Display Function
    public static void DisplayMenu()
    {
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Help");
        Console.WriteLine("3) Exit");
    }
    ////////////////////////////////////////////////////////////////////////

    // Task 5 - Even or Odd Function
    public static bool IsEven(int num)
    {
        return num % 2 == 0;
    }
    ////////////////////////////////////////////////////////////////////////

    
}