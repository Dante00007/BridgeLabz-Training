class MostFrequentChar
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine().ToLower();
        int[] arr = new int[26];
        foreach (char c in str)
        {
            arr[c - 'a']++;
        }
        int max = 0;
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                index = i;
            }
        }
        Console.WriteLine("Most Frequent Character: {0}", (char)(index + 'a'));
    }
}
