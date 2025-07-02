using System;

class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = Hotel.LoadHotel();
        Console.WriteLine($"Welcome to {hotel.Name}");

        Console.Write("Do you have an account? (yes/no): ");
        string answer = Console.ReadLine().Trim().ToLower();

        bool isAuthenticated = false;
        string username = "";

        if (answer == "no")
        {
            Console.Write("Choose a username: ");
            username = Console.ReadLine();
            Console.Write("Choose a password: ");
            string password = Console.ReadLine();

            if (Guest.SignUp(username, password))
            {
                Console.WriteLine("Sign-up successful!");
                isAuthenticated = true;
            }
            else
            {
                Console.WriteLine("Username already exists.");
            }
        }
        else
        {
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            isAuthenticated = Guest.Login(username, password);
            Console.WriteLine(isAuthenticated ? "Login successful!" : "Invalid credentials.");
        }

        if (isAuthenticated)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Book a room");
                Console.WriteLine("2. Cancel a room");
                Console.WriteLine("3. View hotel status");
                Console.WriteLine("4. Exit");

                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        if (ReservationManager.BookRoom(hotel))
                            Console.WriteLine("Room successfully booked.");
                        else
                            Console.WriteLine("Hotel is full.");
                        break;

                    case "2":
                        if (ReservationManager.CancelRoom(hotel))
                            Console.WriteLine("Room successfully canceled.");
                        else
                            Console.WriteLine("No rooms to cancel.");
                        break;

                    case "3":
                        Console.WriteLine($"Hotel: {hotel.Name}, Capacity: {hotel.Capacity}, Booked: {hotel.RoomsBooked}");
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
