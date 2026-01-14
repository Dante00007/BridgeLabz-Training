using System;

class SentenceSearch
{
    static int FindSentenceWithWord(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return i;
            }
        }
        return -1;
    }
    static void Main()
    {
        string[] sentences = {
            "The quick brown fox jumps over the lazy dog.",
            "FinlyTech provides innovative loan solutions.",
            "Linear search is a simple searching algorithm.",
            "Programming in C# is powerful and versatile."
        };

        Console.Write("Enter the word to search for: ");
        string targetWord = Console.ReadLine();

        int index = FindSentenceWithWord(sentences, targetWord);

        if (index != -1)
        {
            Console.WriteLine($"\nWord found in sentence at index {index}:");
            Console.WriteLine($"\"{sentences[index]}\"");
        }
        else
        {
            Console.WriteLine("\nThe word was not found in any sentence.");
        }
    }

    
}