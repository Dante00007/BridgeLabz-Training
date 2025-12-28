
class MaximumCircularSum
{
    public static int MaximumSum(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int maxSum = nums[0];
        int minSum = nums[0];

        int totalSum = 0;
        int currMaxSum = 0;
        int currMinSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            currMaxSum = Math.Max(currMaxSum + nums[i], nums[i]);
            maxSum = Math.Max(maxSum, currMaxSum);

            currMinSum = Math.Min(currMinSum + nums[i], nums[i]);
            minSum = Math.Min(minSum, currMinSum);
            totalSum += nums[i];
        }

        int circularSum = totalSum - minSum;
        if (totalSum == minSum){
            return maxSum;
        }
        return Math.Max(circularSum, maxSum);
    }
    static void Main()
    {
        // nums = [1,-2,3,-2]
        int[] nums = [1, -2, 3, -2];
        Console.WriteLine(MaximumSum(nums));// 3
    }
}