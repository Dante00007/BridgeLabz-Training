class ExtractLanguages
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = @"\b(Java|Python|JavaScript|Go)\b";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}