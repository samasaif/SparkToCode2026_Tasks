namespace Task2;

class Program
{
    static void Main(string[] args)
    {
       // Task 1 - Countdown Timer
       Console.WriteLine("please enter a starting number: ");
       int number = Convert.ToInt32(Console.ReadLine());

       for (int i = number; i >= 1 ; i--)
       {
        Console.WriteLine(i);   
       }
       Console.WriteLine("Liftoff!");  
       Console.WriteLine("\n");
       ////////////////////////////////////////////////////////////////////////////////////////////////
       
    }
    
}