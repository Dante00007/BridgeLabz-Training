class LeapYear
{
    public static bool CheckYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter any year");
        int year = Convert.ToInt32(Console.ReadLine());
        CheckYear(year);

    }
}