using System;
using System.Collections.Generic;

public class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        return new int[0];
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = FindTwoSum(nums, target);

        if (result.Length == 2)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]} ");
            Console.WriteLine($"Values: {nums[result[0]]} + {nums[result[1]]} = {target}");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}