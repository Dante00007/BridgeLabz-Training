class HarryAge
{
    public static void Main()
    {
        int currentYear = DateTime.Now.Year;
        Console.WriteLine("Harry's age in " + currentYear + " is " + (currentYear - 2000) + " years old ");
    }
}