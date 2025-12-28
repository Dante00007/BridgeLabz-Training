

class Anagram
{
    static void Main()
    {
        Console.WriteLine("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter second string: ");
        string str2 = Console.ReadLine();
        bool flag = true;
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("The two strings are not anagrams of each other.");
            return;
        }
        foreach (char c in str1.ToLower())
        {
            if (!str2.ToLower().Contains(c))
            {
                Console.WriteLine("The two strings are not anagrams of each other.");
                return;
            }
        }

        Console.WriteLine("The two strings are anagrams of each other.");

    }
}