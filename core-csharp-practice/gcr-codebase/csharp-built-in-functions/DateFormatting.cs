


class DateFormatting
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now; 
        string formattedDate1 = currentDate.ToString("dd/MM/yyyy");
        string formattedDate2 = currentDate.ToString("yyyy-MM-dd");
        string formattedDate3 = currentDate.ToString("EEE, MMM dd, yyyy");

        Console.WriteLine("Formatted Date 1: " + formattedDate1);
        Console.WriteLine("Formatted Date 2: " + formattedDate2);
        Console.WriteLine("Formatted Date 3: " + formattedDate3);
    }
}