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

public class Program
{
    static void Main(string[] args)
    {
    }
}