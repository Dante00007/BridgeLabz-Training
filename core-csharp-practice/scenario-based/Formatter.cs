/*
Dear Learners,
Try to solve this problem statement
Strings – Sentence Formatter
1. Scenario: A text editing tool receives poorly formatted input from users. Your task is to auto-correct formatting by fixing spacing and capitalizing the first letter of each sentence.
Problem:
Write a method that takes a paragraph as input and returns a corrected version with:
● One space after punctuation,
● Capital letter after period/question/exclamation marks,
● Trimmed extra spaces.

2. Scenario: Create a program that analyzes a given paragraph of text. Implement the following
functionalities:
● Count the number of words in the paragraph.
● Find and display the longest word.
● Replace all occurrences of a specific word with another word (case-insensitive).
● Handle edge cases like empty strings or paragraphs with only spaces.
*/

using System.Text.RegularExpressions;
class Formatter
{
    private string RemoveExtraSpaces(string[] arr)
    {
        string res = "";
        foreach (string item in arr)
        {
            if (item != "")
            {
                res += " " + item;
            }
        }
        return res.Trim();
    }
    private string Capitalization(string str)
    {
        if (str == "" || str == null) return "";

        string[] arr = str.Split(' ');
        string pattern = @"[.!?]";
        for (int i = 1; i < arr.Length; i++)
        {
            if (Regex.IsMatch(arr[i - 1], pattern))
            {
                arr[i] = char.ToUpper(arr[i][0]) + arr[i].Substring(1);
            }
        }
        arr[0] = char.ToUpper(arr[0][0]) + arr[0].Substring(1);
        return string.Join(" ", arr);
    }
    private string Punctuation(string str)
    {
        string pattern = @"([.!?,])\s*";
        string res = Regex.Replace(str, pattern, "$1 ");
        return res.Trim();
    }
    private string FormatUtil()
    {
        Console.WriteLine("Hello Please Insert your paragraph to format");
        string para = Console.ReadLine().Trim();
        string[] arr = para.Split(' ');


        string temp = RemoveExtraSpaces(arr);

        temp = Punctuation(temp);

        string res = Capitalization(temp);



        return res;
    }
    static void Main()
    {
        Formatter formatter = new Formatter();
        Console.WriteLine(formatter.FormatUtil());
    }
}