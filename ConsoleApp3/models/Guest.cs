using System.Text.Json;

public class Guest
{
    public string Username { get; set; }
    public string Password { get; set; }

    private static string filePath = "Data/guests.json";

    public static List<Guest> LoadGuests()
    {
        if (!File.Exists(filePath)) return new List<Guest>();
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Guest>>(json);
    }

public static void SaveGuests(List<Guest> guests)
{
    Directory.CreateDirectory("Data");

    string json = JsonSerializer.Serialize(guests, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filePath, json);
}

    public static bool SignUp(string username, string password)
    {
        var guests = LoadGuests();
        if (guests.Any(g => g.Username == username)) return false;
        guests.Add(new Guest { Username = username, Password = password });
        SaveGuests(guests);
        return true;
    }

    public static bool Login(string username, string password)
    {
        return LoadGuests().Any(g => g.Username == username && g.Password == password);
    }
    
}
