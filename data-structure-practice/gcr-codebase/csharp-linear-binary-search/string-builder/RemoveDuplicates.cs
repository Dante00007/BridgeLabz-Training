using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    public static string CleanString(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder sb = new StringBuilder();
        
        HashSet<char> seen = new HashSet<char>();

        foreach (char c in input)
        {
           
            if (!seen.Contains(c))
            {
                seen.Add(c);    
                sb.Append(c);     
            }
        }

        return sb.ToString();
    }

    static void Main()
    {
        Console.Write("Enter a string with duplicates: ");
        string input = Console.ReadLine();

        string result = CleanString(input);

        Console.WriteLine($"Original: {input}");
        Console.WriteLine($"Result:   {result}");
    }
}