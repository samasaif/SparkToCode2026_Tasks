namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Absolute Difference
        Console.Write("enter the 1st number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        
        Console.Write("enter the 2nd number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        
        double result1 = Math.Abs(secondNumber - firstNumber);
        
        Console.WriteLine("absolute difference of " + secondNumber + "-" + firstNumber + " = " + result1);
        ///////////////////////////////////////////////////////////////////////////////////////////////////
    }
}