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
    
} 
