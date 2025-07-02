public class ReservationManager
{
    public static bool BookRoom(Hotel hotel)
    {
        if (hotel.RoomsBooked >= hotel.Capacity) return false;
        hotel.RoomsBooked++;
        hotel.SaveHotel();
        return true;
    }

    public static bool CancelRoom(Hotel hotel)
    {
        if (hotel.RoomsBooked <= 0)
        {
            return false;
        }
        else
        {
            hotel.RoomsBooked--;
            hotel.SaveHotel();
            return true;
        }
    }
}
