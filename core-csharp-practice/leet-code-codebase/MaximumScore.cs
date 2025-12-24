
class MaximumScore
{
    public static int MaximumSc(int[] nums, int k)
    {

        int n = nums.Length;
        int left = k, right = k;
        int minVal = nums[k];
        int maxScore = nums[k];

        while (left > 0 || right < n - 1)
        {

            if (left == 0)
            {
                right++;
            }
            else if (right == n - 1)
            {
                left--;
            }
            else if (nums[left - 1] > nums[right + 1])
            {
                left--;
            }
            else
            {
                right++;
            }

            minVal = Math.Min(minVal, Math.Min(nums[left], nums[right]));

            maxScore = Math.Max(maxScore, minVal * (right - left + 1));
        }

        return maxScore;
    }
    static void Main()
    {
        int[] nums = new int[] { 1, 4, 3, 7, 4, 5 };
        int k = 3;
        //Explanation: The optimal subarray is (1, 5) with a score of min(4,3,7,4,5) * (5-1+1) = 3 * 5 = 15. 
        Console.WriteLine(MaximumSc(nums, k)); //15

        int[] nums2 = new int[] { 5, 5, 4, 5, 4, 1, 1, 1 };
        k = 0;
        //Explanation: The optimal subarray is (0, 4) with a score of min(5,5,4,5,4) * (4-0+1) = 4 * 5 = 20.
        Console.WriteLine(MaximumSc(nums2, k)); //20


    }
}