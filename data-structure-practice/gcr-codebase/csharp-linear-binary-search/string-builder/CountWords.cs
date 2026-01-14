using System;
using System.IO;

class WordCounter
{
    static void Main()
    {
        string filePath = "Files.txt";
        string targetWord = "GLA";
        int count = 0;

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        if (string.Equals(word, targetWord, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"The word '{targetWord}' appeared {count} times.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}