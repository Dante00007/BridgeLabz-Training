
class TimeZoneAndOffset
{
    static void Main()
    {
        DateTimeOffset nowUtc = DateTimeOffset.UtcNow;

        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(nowUtc, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(nowUtc, pstZone);


        Console.WriteLine("GMT : {0} ", nowUtc.DateTime);

        Console.WriteLine("IST : {0}", istTime.DateTime);

        Console.WriteLine("PST : {0}", pstTime.DateTime);


    }
}
