using System;
using System.Collections.Generic;

public class SubarraySumZero
{
    public static void FindSubarrays(int[] nums)
    {

        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;


        map[0] = new List<int> { -1 };

        Console.WriteLine("Zero Sum Subarrays found at:");

        for (int i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];


            if (map.ContainsKey(cumulativeSum))
            {
                List<int> previousIndices = map[cumulativeSum];
                foreach (int prevIndex in previousIndices)
                {

                    Console.WriteLine($"Start Index: {prevIndex + 1}, End Index: {i}");
                }
                map[cumulativeSum].Add(i);
            }
            else
            {

                map[cumulativeSum] = new List<int> { i };
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };
        FindSubarrays(arr);
    }
}