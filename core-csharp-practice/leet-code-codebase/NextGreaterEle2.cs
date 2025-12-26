using System;
using System.Collections.Generic;

public class NextGreaterEle2 {
    public static int[] NextGreaterElements(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];
        
        
        for (int j = 0; j < n; j++) ans[j] = -1;

        Stack<int> s = new Stack<int>();


        for (int i = 0; i < n; i++) {
            while (s.Count > 0 && nums[s.Peek()] < nums[i]) {
                ans[s.Pop()] = nums[i];
            }
            s.Push(i);
        }

        int k = 0;
        while (s.Count > 0 && k < n) {
            if (nums[k] > nums[s.Peek()]) {
                ans[s.Pop()] = nums[k];
            } else {
                k++;
            }
        }

        return ans;
    }

    static void Main(string[] args) {
        int[] nums = { 1, 2, 1 };
        int[] result = NextGreaterElements(nums);

        Console.WriteLine("Next Greater Elements:");
        Console.WriteLine("[" + string.Join(", ", result) + "]"); 
        // Expected Output: [2, -1, 2]
    }
}