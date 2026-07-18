namespace OOP_Part_1;

// 1- class BankAccount
public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }
    
    public void Deposit(double amount)
    {
        Balance += amount;
        Sendemail();
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Sendemail();
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
    
    public double CheckBalance()
    {
        PrintInformation();
        return Balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine($"Holder Name: {HolderName}");
        Console.WriteLine($"Balance: {Balance}");
    }

    private void Sendemail()
    {
        Console.WriteLine("Sendemail");
    }
}
////////////////////////////////////////////////////////////////////////////////////

// 2- class Student
public class Student
{
    public int Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string email { get; set; }
    int age;

    public void Register(string Email)
    {
        email =  Email;
        SendEmail();
    }

    private void SendEmail()
    {
        Console.WriteLine("Registration email sent.");
    }
}
////////////////////////////////////////////////////////////////////////////////////

// 3- class Product
public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public int StockQuantity  { get; set; }

    public void Sell(int quantity)
    {
        if  (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
        }
        else
        {
            Console.WriteLine("Not enough stock");
        }
    }
    
    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }

    public double GetInventoryValue()
    {
        PrintDetails();
        return StockQuantity;
    }

    private void PrintDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Product Price: " + Price);
        Console.WriteLine("Stock Quantity: " + StockQuantity);
    }

    private void LogTransaction()
    {
        Console.WriteLine("Transaction logged");
    }
}
////////////////////////////////////////////////////////////////////////////////////

public class Program
{
    // create the objects
    static BankAccount account1 = new BankAccount();
    static BankAccount account2 = new BankAccount();

    static Student student1 = new Student();
    static Student student2 = new Student();

    static Product product1 = new Product();
    static Product product2 = new Product();
    
    static void Main(string[] args)
    { 
        account1.AccountNumber = 1163;
        account1.HolderName = "Karim";
        account1.Balance = 120;
        
        account2.AccountNumber = 15203;
        account2.HolderName = "Ali";
        account2.Balance = 63;

        student1.Name = "Ali";
        student1.Address = "Muscat";
        student1.Grade = 65;

        student2.Name = "Ahmed";
        student1.Address = "Muscat";
        student1.Grade = 70;
        
        product1.ProductName = "Wireless Mouse";
        product1.Price = 5.500;
        product1.StockQuantity = 50;
        
        product2.ProductName = "Mechanical Keyboard";
        product1.Price = 15.750;
        product1.StockQuantity = 20;
        
        bool exitApp = false; 
        while (exitApp == false)
        {
            Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
            Console.WriteLine(" 1. View Account Details");
            Console.WriteLine(" 2. Update Student Address");
            Console.WriteLine(" 3. Make a Deposit");
            Console.WriteLine(" 4. Make a Withdrawal");
            Console.WriteLine(" 5. View Product Details");
            Console.WriteLine(" 6. Register a Student");
            Console.WriteLine(" 7. Compare Two Account Balances"); 
            Console.WriteLine(" 8. Restock Product & Stock Level Check"); 
            Console.WriteLine(" 9. Transfer Between Accounts"); 
            Console.WriteLine("10. Update Student Grade (Validated)"); 
            Console.WriteLine("11. Student Report Card"); 
            Console.WriteLine("12. Account Health Status"); 
            Console.WriteLine("13. Bulk Sale With Revenue Calculation"); 
            Console.WriteLine("14. Scholarship Eligibility Check"); 
            Console.WriteLine("15. Full Balance Top-Up Flow"); 
            Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)"); 
            Console.WriteLine("17. Total Students Counter (Static Field & Method)"); 
            Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)"); 
            Console.WriteLine("19. Set Student Security PIN (Write-Only Property)"); 
            Console.WriteLine("20. Exit"); 
            Console.Write("Choose an option: ");
            
            int choice; 
            try 
            { 
                choice = int.Parse(Console.ReadLine()); 
            }
            catch (Exception) 
            { 
                Console.WriteLine("Invalid input. Please enter a number from 1 to 20."); 
                continue; 
            }
            
            switch (choice) 
            { 
                case 1: ViewAccountDetails(); break; 
                case 2: UpdateStudentAddress(); break; 
                case 3: MakeDeposit(); break; 
                case 4: MakeWithdrawal(); break;
                case 5: ViewProductDetails(); break;
                case 6: RegisterStudent(); break;
                case 7: CompareAccountBalances(); break;
                case 8: RestockProduct(); break;
                case 9: TransferBetweenAccounts(); break;
                case 10: UpdateStudentGrade(); break;
                case 11: StudentReportCard(); break;
                case 12: AccountHealthStatus(); break;
                case 13: BulkSaleWithRevenue(); break; 
                case 14: ScholarshipEligibilityCheck(); break;
                case 15: FullBalanceTopUpFlow(); break;
                case 16: QuickAccountOpening(); break;
                case 17: TotalStudentsCounter(); break;
                case 18: OverdrawnAccountCheck(); break;
                case 19: SetStudentSecurityPin(); break;
                case 20: 
                    exitApp = true; 
                    Console.WriteLine("Goodbye!"); 
                    break; 
                default: 
                    Console.WriteLine("Invalid option, please choose between 1 and 20."); 
                    break; 
            } 
            
            
        } 
    } 
    
    // Case 1 - View Account Details
    static void ViewAccountDetails()
    {
        Console.WriteLine("choose account (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            account1.CheckBalance();
            Console.WriteLine("Account Balance: " + account1.Balance);
        }
        else if (choice == 2)
        {
            account2.CheckBalance();
            Console.WriteLine("Account Balance: " + account2.Balance);
        }
        else
        {
            Console.WriteLine("Invalid account. Please choose between 1 and 2.");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 2 - Update Student Address
    static void UpdateStudentAddress()
    {
        Console.WriteLine("choose student (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter new student address: ");
        string address = Console.ReadLine();

        if (choice == 1)
        {
            student1.Address = address;
            Console.WriteLine("New Student Address: " + student1.Address);
        }
        else if (choice == 2)
        {
            student2.Address = address;
            Console.WriteLine("New Student Address: " + student2.Address);
        }
        else
        {
            Console.WriteLine("Invalid student. Please choose between 1 and 2.");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////

    // Case 3 - Make a Deposit
    static void MakeDeposit()
    {
        Console.WriteLine("choose account (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter deposit  amount: ");
        try
        {
            double deposit = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                account1.Deposit(deposit);
                Console.WriteLine("Holder: " + account1.HolderName);
                Console.WriteLine("Account Balance: " + account1.Balance);
            }
            else if (choice == 2)
            {
                account2.Deposit(deposit);
                Console.WriteLine("Holder: " + account2.HolderName);
                Console.WriteLine("Account Balance: " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid account. Please choose between 1 and 2.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid amount");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 4 - Make a Withdrawal
    static void MakeWithdrawal()
    {
        Console.WriteLine("choose account (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter withdrawal amount: ");
        try
        {
            double amount = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                account1.Withdraw(amount);
                Console.WriteLine("Balance: " + account1.Balance);
            }
            else if (choice == 2)
            {
                account2.Withdraw(amount);
                Console.WriteLine("Balance: " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please choose between 1 and 2.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid amount");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 5 - View Product Details
    static void ViewProductDetails()
    {
        Console.WriteLine("choose product (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Total Inventory Value: " + product1.GetInventoryValue());
        }
        else if (choice == 2)
        {
            Console.WriteLine("Total Inventory Value: " + product2.GetInventoryValue());
        }
        else
        {
            Console.WriteLine("Invalid product. Please choose between 1 and 2.");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 6 - Register a Student
    static void RegisterStudent()
    {
        Console.WriteLine("choose student (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter email: ");
        string email = Console.ReadLine();

        if (choice == 1)
        {
            student1.Register(email);
            Console.WriteLine(student1.Name + " has been registered!");
        }
        else if (choice == 2)
        {
            student2.Register(email);
            Console.WriteLine(student2.Name + " has been registered!");
        }
        else
        {
            Console.WriteLine("Invalid student. Please choose between 1 and 2.");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 7 - Compare Two Account Balances
    static void CompareAccountBalances()
    {
        if (account1.Balance < account2.Balance)
        {
            Console.WriteLine(account2.HolderName + " has higher balance than " + account1.HolderName);
        }
        else if (account1.Balance > account2.Balance)
        {
            Console.WriteLine(account1.HolderName + " has higher balance than " + account2.Balance);
        }
        else
        {
            Console.WriteLine("both accounts have the same balance");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 8 - Restock Product & Stock Level Check
    static void RestockProduct()
    {
        Console.WriteLine("choose product (1 or 2): ");
        int choice =  Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("enter a quantity to add: ");

        try
        {
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                product1.Restock(quantity);
                Console.WriteLine("new stock: " + product1.StockQuantity);

                if (product1.StockQuantity < 10)
                {
                    Console.WriteLine("stock level is now LOW!");
                }
                else if (product1.StockQuantity < 50)
                {
                    Console.WriteLine("stock level is now Well Stocked!");
                }
            }
            else if (choice == 2)
            {
                product2.Restock(quantity);
                Console.WriteLine("new stock: " + product2.StockQuantity);

                if (product2.StockQuantity < 10)
                {
                    Console.WriteLine("stock level is now LOW!");
                }
                else if (product2.StockQuantity < 50)
                {
                    Console.WriteLine("stock level is now Well Stocked!");
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid quantity");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 9 - Transfer Between Accounts
    static void TransferBetweenAccounts()
    {
        Console.Write("choose a source account (1 or 2): ");
        int source = Convert.ToInt32(Console.ReadLine());

        Console.Write("choose a destination account (1 or 2): ");
        int destination = Convert.ToInt32(Console.ReadLine());

        if (source == destination)
        {
            Console.WriteLine("Cannot transfer to the same account.");
            return;
        }

        Console.Write("Enter amount to transfer: ");

        double amount;

        try
        {
            amount = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid amount");
            return;
        }

        if (source == 1 && destination == 2)
        {
            if (amount <= account1.Balance)
            {
                account1.Withdraw(amount);
                account2.Deposit(amount);
                Console.WriteLine("Transfer completed!");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        else if (source == 2 && destination == 1)
        {
            if (amount <= account2.Balance)
            {
                account2.Withdraw(amount);
                account1.Deposit(amount);
                Console.WriteLine("Transfer completed!");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        else
        {
            Console.WriteLine("Invalid account selection.");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 10 - Update Student Grade (Validated)
    static void UpdateStudentGrade()
    {
        Console.Write("choose student (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter grade: ");
        int newGrade;
        try
        {
            newGrade = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid integer");
            return;
        }

        if (newGrade < 0 || newGrade > 100)
        {
            Console.WriteLine("Invalid! must be between 0 and 100");
            return;
        }
        if (choice == 1)
        {
            student1.Grade = newGrade;
            Console.WriteLine("Student 1 Grade: " + student1.Grade);
        }
        else if (choice == 2)
        {
            student2.Grade = newGrade;
            Console.WriteLine("Student 2 Grade: " + student2.Grade);
        }
        else
        {
            Console.WriteLine("Invalid student!");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 11 - Student Report Card
    static void StudentReportCard()
    {
        Console.Write("choose student (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        Student student;
        if (choice == 1)
        {
            student = student1;
        }
        else if (choice == 2)
        {
            student = student2;
        }
        else
        {
            Console.WriteLine("Invalid student");
            return;
        }
        
        Console.WriteLine("\nStudent Name: " + student.Name);
        Console.WriteLine("Address: " + student.Address);
        Console.WriteLine("Grade: " + student.Grade);

        if (student.Grade >= 50)
        {
            Console.WriteLine("Result: Pass");
        }
        else
        {
            Console.WriteLine("Result: Fail");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 12 - Account Health Status
    static void AccountHealthStatus()
    {
        Console.Write("choose account (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        BankAccount account;
        
        if (choice == 1)
        {
            account = account1;
        }
        else if (choice == 2)
        {
            account = account2;
        }
        else
        {
            Console.WriteLine("Invalid account");
            return;
        }
        
        if (account.Balance < 50)
        {
            Console.WriteLine("status : Low Balance");
        }
        else if (account.Balance <= 1000)
        {
            Console.WriteLine("status : Healthy");
        }
        else
        {
            Console.WriteLine("status : Premium");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 13 - Bulk Sale With Revenue Calculation
    static void BulkSaleWithRevenue()
    {
        Console.Write("choose product (1 or 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter quantity to sell: ");
        try
        {
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                if (quantity > product1.StockQuantity)
                {
                    Console.WriteLine("Not enough stock!");
                    Console.WriteLine("need " + (quantity - product1.StockQuantity) + " more units.");
                }
                else
                {
                    product1.Sell(quantity);

                    double revenue = quantity * product1.Price;

                    Console.WriteLine("Remaining Stock: " + product1.StockQuantity);
                    Console.WriteLine("Revenue: " + revenue);
                }
            }
            else if (choice == 2)
            {
                if (quantity > product2.StockQuantity)
                {
                    Console.WriteLine("Not enough stock!");
                    Console.WriteLine("need " + (quantity - product2.StockQuantity) + " more units.");
                }
                else
                {
                    product2.Sell(quantity);

                    double revenue = quantity * product2.Price;

                    Console.WriteLine("Remaining Stock: " + product2.StockQuantity);
                    Console.WriteLine("Revenue: " + revenue);
                }
            }
            else
            {
                Console.WriteLine("Invalid product!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid quantity!");
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 14 - Scholarship Eligibility Check
    static void ScholarshipEligibilityCheck()
    {
        
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 15 - Full Balance Top-Up Flow
    static void FullBalanceTopUpFlow()
    {
        
    }
    ////////////////////////////////////////////////////////////////////////////////////

    // Case 16 - Quick Account Opening [Parameterized Constructor]
    static void QuickAccountOpening()
    {
        
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 17 - Total Students Counter [Static Fields & Methods]
    static void TotalStudentsCounter()
    {
        
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 18 - Overdrawn Account Check [Read-Only Property]
    static void OverdrawnAccountCheck()
    {
        
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    // Case 19 - Set Student Security PIN [Write-Only Property]
    static void SetStudentSecurityPin()
    {
        
    }
    ////////////////////////////////////////////////////////////////////////////////////
    
    
    
    
    
    
    
    
    
} 
