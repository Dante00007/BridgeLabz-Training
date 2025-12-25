
class SpringSeason
{
    public static bool IsSpring(int month,int day)
    {
        if((month == 3 && day >= 20) || (month > 3 && month <6 )|| (month == 6 && day <= 20))
            return true;
        return false;
    }
    static void Main()
    {
        Console.Write("Enter Month : ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Day : ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool result = IsSpring(month,day);

        if(result==true)
            Console.WriteLine("It's a spring season");
        else
            Console.WriteLine("Not a spring season");
    }
}