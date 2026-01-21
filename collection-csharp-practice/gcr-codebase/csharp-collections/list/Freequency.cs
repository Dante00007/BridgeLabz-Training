using System;
using System.Collections.Generic;
class Frequency
{
    static void Main(string[] args)
    {
        string[] arr = {"apple", "banana", "apple", "orange"};

        Dictionary<string, int> dict = new Dictionary<string, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (dict.ContainsKey(arr[i]))
            {
                dict[arr[i]] += 1;
            }
            else
            {
                dict[arr[i]] = 1;
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + ": " + item.Value);

        }
    }
}