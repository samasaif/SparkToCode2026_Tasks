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
    static List<Guest> guests = new List<Guest>();
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
        
        // Case 02 Register New Guest 
        static void RegisterGuest()
        {
            Console.Write("Enter Guest Name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter Check-in Date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter Number of Nights: ");

            int totalNights;

            try
            {
                totalNights = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number of nights!");
                return;
            }

            if (totalNights <= 0)
            {
                Console.WriteLine("Number of nights must be greater than zero");
                return;
            }
            // Auto-generate the guest ID from the current size of the guests list (format: G001, G002, G003 ...)
            string guestId = "G" + (guests.Count + 1).ToString("D3"); // D = Decimal (display the number as an integer)
                                                                            // 3 = Always use at least 3 digits. If the number has fewer than 3 digits, add leading zeros
            Guest newGuest = new Guest(
                guestId,
                guestName,
                "Not Assigned",
                checkInDate,
                totalNights
            );
            guests.Add(newGuest);
            
            Console.WriteLine("\nGuest Registered Successfully!");
            Console.WriteLine("Guest ID: " + guestId);
            Console.WriteLine("Guest Name: " + guestName);
            Console.WriteLine("Room Number: Not Assigned");
            Console.WriteLine("Check-in Date: " + checkInDate);
            Console.WriteLine("Total Nights: " + totalNights);
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        
        // Case 03 Book a Room for a Guest 
        static void BookRoom()
        {
            Console.Write("Enter Guest ID: ");
            string guestId = Console.ReadLine();
            Console.Write("Enter Room Number: ");
            int roomNumber;
            try
            {
                roomNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid room number");
                return;
            }
            Guest guest = guests.FirstOrDefault(g => g.guestId == guestId);

            if (guest == null)
            {
                Console.WriteLine("Guest not found");
                return;
            }
            Room room = rooms.FirstOrDefault(r => r.roomNumber == roomNumber);

            if (room == null)
            {
                Console.WriteLine("Room not found");
                return;
            }

            if (room.isAvailable == false)
            {
                Console.WriteLine("Room is already booked");
                return;
            }
            guest.roomNumber = room.roomNumber.ToString();
            room.isAvailable = false;

            Console.WriteLine("\nBooking Successful!");
            Console.WriteLine("Guest Name: " + guest.guestName);
            Console.WriteLine("Room Number: " + room.roomNumber);
            Console.WriteLine("Room Type: " + room.roomType);
            Console.WriteLine("Price Per Night: " + room.pricePerNight);
            Console.WriteLine("Total Nights: " + guest.totalNights);
            Console.WriteLine("Total Cost: " + guest.calculateTotalCost(room.pricePerNight));
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        
        // Case 04 View All Rooms 
        static void ViewAllRooms()
        {
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            Console.WriteLine("Total Rooms: " + rooms.Count());

            var roomList = rooms
                                           .OrderBy(r => r.roomNumber)
                                           .Select(r => r);

            foreach (Room room in roomList)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Room Number: " + room.roomNumber);
                Console.WriteLine("Room Type: " + room.roomType);
                Console.WriteLine("Price Per Night: " + room.pricePerNight);

                if (room.isAvailable)
                {
                    Console.WriteLine("Status: Available");
                }
                else
                {
                    Console.WriteLine("Status: Booked");
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        
        // Case 05 View All Guests 
        static void ViewAllGuests()
        {
            if (guests.Count() == 0)
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            Console.WriteLine("Total Guests: " + guests.Count());

            var guestList = guests
                                             .OrderBy(g => g.guestName)
                                             .Select(g => g);
            foreach (Guest guest in guestList)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Guest ID: " + guest.guestId);
                Console.WriteLine("Guest Name: " + guest.guestName);
                Console.WriteLine("Room Number: " + guest.roomNumber);
                Console.WriteLine("Check-in Date: " + guest.checkInDate);
                Console.WriteLine("Total Nights: " + guest.totalNights);
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////
        
        
        
        
        
        
        
        
        
        
        }
}