class ExtractCurrency
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = @"\$\s?\d+(\.\d{2})?";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}
