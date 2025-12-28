

class Replace
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string str = Console.ReadLine().ToLower();
        Console.WriteLine("Enter the word to be replaced: ");
        string oldWord = Console.ReadLine().ToLower();
        Console.WriteLine("Enter the replacement word: ");
        string newWord = Console.ReadLine().ToLower();
        string[] words = str.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == oldWord)
            {
                words[i] = newWord;
            }
        }
        string newStr = string.Join(" ", words);
        Console.WriteLine("Modified String: {0}", newStr);
    }
}