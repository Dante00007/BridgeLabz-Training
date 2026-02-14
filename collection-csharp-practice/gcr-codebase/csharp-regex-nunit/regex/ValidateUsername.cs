
using System.Text.RegularExpressions;

class ValidateUsername
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();
        string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";
        bool isValid = Regex.IsMatch(username, pattern);
        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}