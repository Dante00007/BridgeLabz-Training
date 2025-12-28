class SubstringOccurrence
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine().ToLower();
        Console.WriteLine("Enter a substring: ");
        string subStr = Console.ReadLine().ToLower();
        int count = 0;
        for(int i=0;i<str.Length-subStr.Length+1;i++)
        {
            if(str.Substring(i,subStr.Length)==subStr)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
