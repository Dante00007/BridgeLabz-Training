using System;
using System.Collections.Generic;

public class PairSum
{
    public static bool HasPairWithSum(int[] nums, int target)
    {
        HashSet<int> visited = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (visited.Contains(complement))
            {
                Console.WriteLine("Pair found: " + complement + " + " + nums[i] + " = " + target);
                return true;
            }

            visited.Add(nums[i]);
        }

        return false;
    }

    public static void Main()
    {
        int[] arr = { 10, 5, 2, 3, 7, 5 };
        int target = 12;

        if (!HasPairWithSum(arr, target))
        {
            Console.WriteLine("No pair exists with the given sum.");
        }
    }
}