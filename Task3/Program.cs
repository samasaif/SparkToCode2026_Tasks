namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Absolute Difference
        /*
        Console.Write("enter the 1st number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        
        Console.Write("enter the 2nd number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        
        double result1 = Math.Abs(secondNumber - firstNumber);
        
        Console.WriteLine("absolute difference of " + secondNumber + "-" + firstNumber + " = " + result1);
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Task 2 - Power & Root Explorer
        Console.Write("enter a number: ");
        double input = double.Parse(Console.ReadLine());
        
        double square = Math.Pow(input, 2);
        double squareRoot = Math.Sqrt(input);
        
        Console.WriteLine("square root of " + input + " = " + squareRoot);
        Console.WriteLine("square of " + input + " = " + square);
        ///////////////////////////////////////////////////////////////////////////////////////////////////

    }
}