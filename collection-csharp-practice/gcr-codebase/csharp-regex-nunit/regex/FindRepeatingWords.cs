class FindRepeatingWords
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(input, pattern);
        foreach (Match match in matches)
            Console.WriteLine(match.Groups[1].Value);
    }
}

