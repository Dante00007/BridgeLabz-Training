class Duplicate
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        string newStr = "";
        foreach(char c in str)
        {
            if (!newStr.Contains(c))
            {
                newStr += c;
            }
        }
        Console.WriteLine(newStr);

    }
}