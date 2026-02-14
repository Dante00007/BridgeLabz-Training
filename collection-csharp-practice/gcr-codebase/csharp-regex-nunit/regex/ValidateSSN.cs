class ValidateSSN
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        bool isValid = Regex.IsMatch(input, pattern);
        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}