
class ArgumentOutOfRange
{
    static void Main()
    {
        try
        {
            string str = "Hello";
            Console.WriteLine(str.Substring(6, 5));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}