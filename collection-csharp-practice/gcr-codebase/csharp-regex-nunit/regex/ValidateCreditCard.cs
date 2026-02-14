class ValidateCreditCard
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"^(4|5)[0-9]{15}$";
        bool isValid = Regex.IsMatch(input, pattern);
        Console.WriteLine(isValid ? "Valid" : "Invalid");
    }
}