class LongestWord
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string str = Console.ReadLine();
        string[] words = str.Split(' ');
        int maxLen = 0;
        string longestWord = "";
        foreach(string word in words)
        {
            if(word.Length > maxLen)
            {
                maxLen = word.Length;
                longestWord = word;
            }
        }
        Console.WriteLine(longestWord);
    }
}
