namespace Task4;

class Program
{
    static void Main(string[] args)
    { 
        // Task 1 - Personalized Welcome Function
       Console.Write("enter your name: ");
       string name = Console.ReadLine();
       WelcomMssg(name);
    }
    
    // Task 1 - Personalized Welcome Function
    public static void WelcomMssg(string name)
    { Console.WriteLine($"Welcome {name}!"); }
}