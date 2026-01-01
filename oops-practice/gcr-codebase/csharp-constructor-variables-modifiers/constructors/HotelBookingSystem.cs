/*
Create a HotelBooking class with attributes guestName, roomType, and nights.
Use default, parameterized, and copy constructors to initialize bookings.
*/

class HotelBookingSystem
{
    public string GuestName;
    public string RoomType ;
    public int Nights;

    public HotelBooking()
    {
    }
    public HotelBooking(string guestName,string roomType,int nights)
    {
        this.GuestName=guestName;
        this.RoomType=roomType;
        this.Nights=nights; 
    } 
    public static void Main(string[] args)
    {
        HotelBooking booking1 = new HotelBooking();
    }
}