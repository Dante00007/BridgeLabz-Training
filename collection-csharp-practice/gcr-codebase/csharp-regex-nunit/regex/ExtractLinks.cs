class ExtractLinks
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = @"https?://[^\s,]+";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}