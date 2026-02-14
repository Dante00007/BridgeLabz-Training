class ExtractCapitalizedWords
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]*\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}