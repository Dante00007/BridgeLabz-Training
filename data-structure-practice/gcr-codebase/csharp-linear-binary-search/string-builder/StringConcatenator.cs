using System;
using System.Text;

class StringConcatenator
{
    public static string ConcatenateStrings(string[] words)
    {
        if (words == null || words.Length == 0)
            return string.Empty;

        StringBuilder sb = new StringBuilder();

        foreach (string s in words)
        {
            sb.Append(s);
        }

        return sb.ToString();
    }

    static void Main()
    {
        string[] inputs = { "Concatenating ", "strings ", "with ", "StringBuilder ", "is ", "efficient." };
        
        string result = ConcatenateStrings(inputs);
        
        Console.WriteLine("Combined String:");
        Console.WriteLine(result);
    }
}