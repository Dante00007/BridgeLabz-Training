/*
1. Count Vowels and Consonants
Problem:
Write a C# program to count the number of vowels and consonants in a given string.
*/

class CountVowCon
{
    static void Main()
    {
        int vowel = 0, cons = 0;
        Console.WriteLine("Enter String:");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.ToLower(str[i]) == 'a' || 
                    Char.ToLower(str[i]) == 'e' || 
                    Char.ToLower(str[i]) == 'i' || 
                    Char.ToLower(str[i]) == 'o' || 
                    Char.ToLower(str[i]) == 'u' ){
                vowel++;
            }
            else
            {
                cons++;
            }
        }
        Console.WriteLine("Number of Vowels: " + vowel);
        Console.WriteLine("Number of Consonants: " + cons);
    }
}