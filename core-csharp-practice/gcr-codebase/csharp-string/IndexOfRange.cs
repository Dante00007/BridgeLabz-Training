

class IndexOfRange
{
    public static void Main()
    {
       
       
        try
        {
            string str = "Hello";
            Console.WriteLine(str[6]);    
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}