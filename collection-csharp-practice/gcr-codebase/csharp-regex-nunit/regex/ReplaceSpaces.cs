
class ReplaceSpaces
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\s+";
        string result = Regex.Replace(input, pattern, " ");
        Console.WriteLine(result);
    }
}