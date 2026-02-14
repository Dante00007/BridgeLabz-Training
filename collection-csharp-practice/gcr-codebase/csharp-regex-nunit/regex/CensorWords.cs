class CensorWords
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\b(damn|stupid)\b";
        string result = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);
        Console.WriteLine(result);
    }
}
