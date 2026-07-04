namespace Task2;

class Program
{
    static void Main(string[] args)
    {
       // Task 1 - Countdown Timer
       /*
         
        
       Console.WriteLine("please enter a starting number: ");
       int number = Convert.ToInt32(Console.ReadLine());

       for (int i = number; i >= 1 ; i--)
       {
        Console.WriteLine(i);   
       }
       Console.WriteLine("Liftoff!");  
       Console.WriteLine("\n");
       */
       ////////////////////////////////////////////////////////////////////////////////////////////////
       
       // Task 2 - Sum of Numbers 1 to N
       /*
       Console.Write("please enter a positive whole number: ");
       int positiveNumber = Convert.ToInt32(Console.ReadLine());

       int total = 0;
       for (int i = 0; i <= positiveNumber; i++)
       {
           total += i;
       }
       Console.WriteLine($"Your total is: {total}");
        */
       ////////////////////////////////////////////////////////////////////////////////////////////////

       // Task 3 - Multiplication Table
       /*
       Console.Write("please enter a number: ");
       int num = Convert.ToInt32(Console.ReadLine());
       for (int i = 0; i <= 10; i++)
       {
           Console.WriteLine(num + " x " + i + " = " + (num * i));
       }
       */
       ////////////////////////////////////////////////////////////////////////////////////////////////
       
       // Task 4 - Password Retry
       /*
       string password = "Spark2026";
       string password2 = "";
       while (password2 != password) {
           Console.WriteLine("Please enter password: ");
           password2 = Console.ReadLine();

           if (password == password2) {
               Console.WriteLine("Access Granted");
           }
           else {
               Console.WriteLine("Incorrect password, try again");
           }
       */
       ////////////////////////////////////////////////////////////////////////////////////////////////

       // Task 5 - Number Guessing Game
       /*
       int secretNum = 42;
       int attempts = 0;
       int guessedNumber;
       do
       {
           Console.WriteLine("guess the number"); ;
           guessedNumber = Convert.ToInt32(Console.ReadLine());
           attempts++;
           if (guessedNumber > secretNum) {
               Console.WriteLine("Too high");
           }
           else if (guessedNumber < secretNum) {
               Console.WriteLine("Too low");
           }
       } while (guessedNumber != secretNum);
       Console.WriteLine("correct");
       Console.WriteLine("attempts: " + attempts);
       */
       ////////////////////////////////////////////////////////////////////////////////////////////////

    }
    
}