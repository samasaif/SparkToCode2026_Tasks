namespace OOP_Part_2;
public class Room
{
    public int roomNumber;
    public string roomType;
    public double pricePerNight;
    public bool isAvailable;

    public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
    {
        this.roomNumber = roomNumber;
        this.roomType = roomType;
        this.pricePerNight = pricePerNight;
        this.isAvailable = isAvailable;
    }

    public void displayRoom()
    {
        Console.WriteLine("Room Number: " + roomNumber);
        Console.WriteLine("Room Type: " + roomType);
        Console.WriteLine("Room Price per Night: " + pricePerNight);

        if (isAvailable)
        {
            Console.WriteLine("Room Available");
        }
        else
        {
            Console.WriteLine("Room Not Available");
        }
    }
}

public class Guest
{
    public string guestId;
    public string guestName;
    public string roomNumber;
    public string checkInDate;
    public int totalNights;

    public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
    {
        this.guestId = guestId;
        this.guestName = guestName;
        this.roomNumber = roomNumber;
        this.checkInDate = checkInDate;
        this.totalNights = totalNights;
    }

    public void displayGuest()
    {
        Console.WriteLine("Guest ID: " + guestId);
        Console.WriteLine("Guest Name: " + guestName);
        Console.WriteLine("Room Number: " + roomNumber);
        Console.WriteLine("Check In Date: " + checkInDate);
        Console.WriteLine("Total Nights: " + totalNights);
    }

    public double calculateTotalCost(double price)
    {
        return price * totalNights;
    }
}

public class Program
{
    static List<Room> rooms = new List<Room>(); 
    List<Guest> guests = new List<Guest>();
    static void Main(string[] args)
    {
        rooms.Add(new Room(101, "Single", 20, true));
        rooms.Add(new Room(102, "Double", 40, true));
        rooms.Add(new Room(103, "Suite", 80, true));
        rooms.Add(new Room(104, "Single", 20, true));
        rooms.Add(new Room(105, "Double", 40, true));
        rooms.Add(new Room(106, "Suite", 80, true));
        
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");
            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room for a Guest");
            Console.WriteLine("4. View All Rooms");
            Console.WriteLine("5. View All Guests");
            Console.WriteLine("6. Search & Filter Rooms");
            Console.WriteLine("7. Guest & Booking Statistics");
            Console.WriteLine("8. Update Room Price");
            Console.WriteLine("9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("================================================");
            Console.WriteLine("Enter your choice: ");

            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid choice");
                continue;
            }

            switch (choice)
            {
                case 1: AddNewRoom(); break;
                case 2: RegisterGuest();  break;
                case 3: BookRoom(); break;
                case 4: ViewAllRooms(); break;
                case 5: ViewAllGuests(); break;
                case 6: SearchRooms(); break;
                case 7: BookingStatistics(); break;
                case 8: UpdateRoomPrice(); break;
                case 9: GuestLookup(); break;
                case 10: RoomBreakdown(); break;
                case 11: CheckoutGuest(); break;
                case 12: RemoveUnavailableRooms(); break;
                case 13: ExtendStay(); break;
                case 14: HighestRevenueBooking(); break;
                case 15: GuestPagination(); break;
                case 0:
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        // Case 01 Add New Room 
        static void AddNewRoom()
        {
            Console.Write("Enter room number: ");

            int roomNumber;

            try
            {
                roomNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid room number.");
                return;
            }

            foreach (Room room in rooms)
            {
                if (room.roomNumber == roomNumber)
                {
                    Console.WriteLine("Room number already exists!");
                    return;
                }
            }
            Console.Write("Enter room type (Single/Double/Suite): ");
            string roomType = Console.ReadLine();

            if (roomType != "Single" && roomType != "Double" && roomType != "Suite")
            {
                Console.WriteLine("Invalid room type!");
                return;
            }

            Console.Write("Enter price per night: ");

            double price;

            try
            {
                price = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid price!");
                return;
            }

            if (price <= 0)
            {
                Console.WriteLine("Price must be greater than zero");
                return;
            }

            rooms.Add(new Room(roomNumber, roomType, price, true));

            Console.WriteLine("Room added successfully!");
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        
        
        
        
        
        
        
        
    }
}