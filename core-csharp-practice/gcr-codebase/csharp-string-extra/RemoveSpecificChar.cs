class RemoveSpecificChar
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine().ToLower();
        Console.WriteLine("Enter a character to remove: ");
        char ch = Console.ReadLine().ToLower()[0];
        string newStr = "";
        foreach (char c in str)
        {
            if (c != ch)
            {
                newStr += c;
            }
        }
        Console.WriteLine("Modified String: {0}", newStr);
    }
}