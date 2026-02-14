class ValidateHexColor
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"^#[0-9A-Fa-f]{6}$";
        bool isValid = Regex.IsMatch(input, pattern);
        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}

