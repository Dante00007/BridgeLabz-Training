class ExtractEmails
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Value);
    }
}