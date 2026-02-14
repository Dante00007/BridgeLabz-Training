using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordCounter
{
    static void Main(string[] args)
    {
        string file = "text.txt";
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string content = reader.ReadToEnd();
                string[] words = content.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    string cleanWord = word.ToLower();
                    if (wordCounts.ContainsKey(cleanWord)) wordCounts[cleanWord]++;
                    else wordCounts[cleanWord] = 1;
                }
            }

            var top5 = wordCounts.OrderByDescending(x => x.Value).Take(5);
            foreach (var pair in top5)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}