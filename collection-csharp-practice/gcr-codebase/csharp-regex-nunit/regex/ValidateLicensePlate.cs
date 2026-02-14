class ValidateLicensePlate
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"^[A-Z]{2}[0-9]{4}$";
        bool isValid = Regex.IsMatch(input, pattern);
        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}