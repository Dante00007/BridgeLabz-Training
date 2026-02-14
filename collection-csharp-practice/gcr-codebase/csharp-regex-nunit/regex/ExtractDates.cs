class ExtractDates
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}
