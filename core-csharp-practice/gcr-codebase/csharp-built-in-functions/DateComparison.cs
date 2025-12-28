
class DateComparison
{
    static void Main()
    {
        Console.Write("Enter a date: ");
        DateTime date1 = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter another date: ");
        DateTime date2 = DateTime.Parse(Console.ReadLine());
        int comparisonResult = DateTime.Compare(date1, date2);

        if (comparisonResult < 0)
        {
            Console.WriteLine("Date 1 is before Date 2");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("Date 1 is after Date 2");
        }
        else
        {
            Console.WriteLine("Date 1 is the same as Date 2");
        }
    }
}   

  