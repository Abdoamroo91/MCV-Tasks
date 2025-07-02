using System.Text.Json;
using System.IO;

public class Hotel
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public int RoomsBooked { get; set; }

    private static string filePath = "Data/hotel.json";

    public static Hotel LoadHotel()
    {
        if (!File.Exists(filePath)) return new Hotel { Name = "Marriott Resort", Capacity = 10, RoomsBooked = 5 };
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Hotel>(json);
    }

    public void SaveHotel()
    {
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
