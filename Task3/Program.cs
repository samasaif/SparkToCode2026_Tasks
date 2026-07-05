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
        /*
        Console.Write("enter a number: ");
        double input = double.Parse(Console.ReadLine());
        
        double square = Math.Pow(input, 2);
        double squareRoot = Math.Sqrt(input);
        
        Console.WriteLine("square root of " + input + " = " + squareRoot);
        Console.WriteLine("square of " + input + " = " + square);
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 3 - Name Formatter
        /*
        Console.Write("enter your full name: ");
        string fullName = Console.ReadLine();
        
        Console.WriteLine("Uppercase: "  + fullName.ToUpper());
        Console.WriteLine("Lowercase: "  + fullName.ToLower());
        Console.WriteLine("Length : " + fullName.Length);
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 4 - Subscription End Date
        /*
        Console.Write("enter the number of days of a free trial: ");
        int freeTrials = int.Parse(Console.ReadLine());
        
        DateTime startSubscription = DateTime.Today;
        DateTime endSubscription = startSubscription.AddDays(freeTrials);
        
        string formattedDate = endSubscription.ToString("yyyy-MM-dd");
        Console.WriteLine("your subscription ends on: " + formattedDate);
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 5 - Grade Rounding System
        /*
        Console.Write("enter your exam score: ");
        double examScore = Convert.ToDouble(Console.ReadLine());
        
        double roundedScore = Math.Round(examScore);
        Console.WriteLine("rounded score: " +  roundedScore);

        if (roundedScore >= 60) {
            Console.WriteLine("PASS");
        }else {
            Console.WriteLine("FAIL");
        }
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
        // Task 6 - Password Strength Checker
        /*
        Console.Write("enter password: ");
        string password = Console.ReadLine();

        if (password.Length >= 8 && !password.ToLower().Contains("password")) {
            Console.WriteLine("strong password");
            
        }else if (password.ToLower().Contains("password")) {
            Console.WriteLine("weak password | it has the word password");
            
        }else if (password.Length < 8) {
            Console.WriteLine("weak password |must be at least 8 characters long.");
        }
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 7 - Clean Name Comparator
        /*
        Console.Write("enter the first name: ");
        string firstName = Convert.ToString(Console.ReadLine());
        
        Console.Write("enter the first name again: ");
        string secondName = Convert.ToString(Console.ReadLine());

        if (firstName.Trim().ToLower() == secondName.Trim().ToLower())
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("No match");
        }
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 8 - Membership Expiry Checker
        /*
        Console.Write("enter your membership start date as text (e.g. \"2026-01-10\"): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());
        
        Console.Write("enter the number of valid membership days: ");
        int days = int.Parse(Console.ReadLine());
        
        DateTime expiryDate = startDate.AddDays(days);
        
        Console.WriteLine("expiry date: " + expiryDate.ToString("yyyy-MM-dd"));

        if (expiryDate >= DateTime.Today)
        {
            Console.WriteLine("membership is active");
        }
        else
        {
            Console.WriteLine("membership is expired");
        }
        */
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 9 - Round Up / Round Down Explorer
        Console.Write("enter a decimal number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        double rounded = Math.Round(number);
        double roundedUp = Math.Ceiling(number);
        double roundedDown = Math.Floor(number);

        Console.WriteLine("rounded: " + rounded);
        Console.WriteLine("rounded UP: " + roundedUp);
        Console.WriteLine("rounded DOWN: " + roundedDown);
        ///////////////////////////////////////////////////////////////////////////////////////////////////
        
    }
}