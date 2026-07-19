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
    List<Room> rooms = new List<Room>();
    List<Guest> guests = new List<Guest>();
    static void Main(string[] args)
    {
    }
}