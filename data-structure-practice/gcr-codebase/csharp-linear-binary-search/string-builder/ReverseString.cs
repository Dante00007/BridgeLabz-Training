using System;
using System.Text;

class ReverseString
{
    private string Reverse(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

       
        StringBuilder sb = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        return sb.ToString();
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string original = Console.ReadLine();

        string reversed = Reverse(original);

        Console.WriteLine($"Original: {original}");
        Console.WriteLine($"Reversed: {reversed}");
    }
}