namespace Task4;

class Program
{
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
       Console.WriteLine("the square of "+ number + " = " + SquareNum(number));
       ////////////////////////////////////////////////////////////////////////
    }
    
    // Task 1 - Personalized Welcome Function
    public static void WelcomMssg(string name)
    { Console.WriteLine($"Welcome {name}!"); }
    ////////////////////////////////////////////////////////////////////////
    
    // Task 2 - Square Number Function
    public static int SquareNum(int number)
    {return number * number;}
    ////////////////////////////////////////////////////////////////////////
}