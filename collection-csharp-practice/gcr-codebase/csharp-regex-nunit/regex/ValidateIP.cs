class ValidateIP
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        bool isValid = Regex.IsMatch(input, pattern);
        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}