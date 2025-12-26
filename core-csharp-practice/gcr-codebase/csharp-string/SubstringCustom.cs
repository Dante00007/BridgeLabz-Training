class SubstringCustom
{
     static void Main()
    {
     
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        Console.Write("Enter start index: ");
        int startIndex = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter end index: ");
        int endIndex = Convert.ToInt32(Console.ReadLine());

        string substring = GetSubstring(str, startIndex, endIndex);

        Console.WriteLine("Custom Method Result: {0}" , substring);
        Console.WriteLine("String.Substring() Result: {0}" , str.Substring(startIndex, endIndex - startIndex + 1));
    }

   static string GetSubstring(string str, int startIndex, int endIndex)
    {
        string result = "";
        for (int i = startIndex; i <= endIndex; i++)
        {
            result += str[i];
        }
        return result;
    }
}