namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer
        Console.WriteLine("please enter a starting number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = number; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Liftoff!");
        Console.WriteLine("\n");

        ////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 2 - Sum of Numbers 1 to N

        Console.Write("please enter a positive whole number: ");
        int positiveNumber = Convert.ToInt32(Console.ReadLine());

        int total = 0;
        for (int i = 0; i <= positiveNumber; i++)
        {
            total += i;
        }

        Console.WriteLine($"Your total is: {total}");
        ////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 3 - Multiplication Table
        Console.Write("please enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        // Task 4 - Password Retry
        string password = "Spark2026";
        string password2 = "";
        while (password2 != password)
        {
            Console.WriteLine("Please enter password: ");
            password2 = Console.ReadLine();

            if (password == password2)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Incorrect password, try again");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 5 - Number Guessing Game
            int secretNum = 42;
            int attempts = 0;
            int guessedNumber;
            do
            {
                Console.WriteLine("guess the number");
                ;
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (guessedNumber > secretNum)
                {
                    Console.WriteLine("Too high");
                }
                else if (guessedNumber < secretNum)
                {
                    Console.WriteLine("Too low");
                }
            } while (guessedNumber != secretNum);

            Console.WriteLine("correct");
            Console.WriteLine("attempts: " + attempts);
            ////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 6 - Safe Division Calculator
            try
            {
                Console.Write("enter 1st number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("enter 2nd number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("cannot divide by zero.");
                }
                else
                {
                    double result = num1 / num2;
                    Console.WriteLine("Result = " + result);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered.");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 7 - Repeating Menu with Exit Option
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Current Time-of-day Greeting");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("hello!");
                            break;

                        case 2:
                            Console.WriteLine("have a wonderful day!");
                            break;

                        case 3:
                            exit = true;
                            Console.WriteLine("bye!");
                            break;

                        default:
                            Console.WriteLine("invalid choice.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("please enter a valid number.");
                }
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 8 - Sum of Even Numbers Only
            Console.Write("please enter a positive whole number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int summ = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    summ += i;
                }
            }

            Console.WriteLine("sum of even numbers = " + sum);
            ////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 9 - Validated Positive Number Input
            int numbr = 0;
            bool validInput = false;
            do
            {
                try
                {
                    Console.Write("enter a positive whole number: ");
                    numbr = Convert.ToInt32(Console.ReadLine());
                    if (numbr > 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("please enter a positive whole number: ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input... Please enter a whole number.");
                }
            } while (!validInput);

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
            ////////////////////////////////////////////////////////////////////////////////////////////////

            // Task 10 - Simple ATM Simulation
            int correctPin = 1234;
            double balance = 100.000;
            int attempt = 0;
            bool pinCorrect = false;

            while (attempt < 3 && !pinCorrect)
            {
                try
                {
                    Console.Write("Enter PIN: ");
                    int pin = Convert.ToInt32(Console.ReadLine());

                    if (pin == correctPin)
                    {
                        pinCorrect = true;
                    }
                    else
                    {
                        attempt++;
                        Console.WriteLine("Incorrect PIN.");
                    }
                }
                catch (FormatException)
                {
                    attempt++;
                    Console.WriteLine("Invalid PIN.");
                }
            }

            if (!pinCorrect)
            {
                Console.WriteLine("Card Blocked");
                return;
            }
            bool exitt = false;

            while (!exitt)
            {
                Console.WriteLine();
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Console.Write("enter deposit amount: ");
                                double deposit = Convert.ToDouble(Console.ReadLine());

                                if (deposit < 0)
                                {
                                    Console.WriteLine("amount cannot be negative");
                                }
                                else
                                {
                                    balance += deposit;
                                    Console.WriteLine("New Balance: " + balance + " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid amount.");
                            }

                            break;

                        case 2:
                            try
                            {
                                Console.Write("Enter withdrawal amount: ");
                                double withdraw = Convert.ToDouble(Console.ReadLine());

                                if (withdraw < 0)
                                {
                                    Console.WriteLine("amount cannot be negative");
                                }
                                else if (withdraw > balance)
                                {
                                    Console.WriteLine("Insufficient balance");
                                }
                                else
                                {
                                    balance -= withdraw;
                                    Console.WriteLine("New Balance: " + balance + " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid amount.");
                            }

                            break;

                        case 3:
                            Console.WriteLine("Current Balance: " + balance + " OMR");
                            break;

                        case 4:
                            exit = true;
                            Console.WriteLine("Thank you");
                            break;

                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid menu option");
                }
            }
        }
    }
}
    
