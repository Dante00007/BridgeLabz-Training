using System;
using System.Collections.Generic;

public class LongestConsecutiveSubSequence
{
    public static int FindLongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                }
            }
        }

        return longestStreak;
    }

    public static void Main()
    {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        int result = FindLongestConsecutive(arr);
        
        Console.WriteLine("Array: " + string.Join(", ", arr));
        Console.WriteLine("Length of Longest Consecutive Sequence: " + result);
    }
}