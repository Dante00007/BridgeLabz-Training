using System;

class MedianTwoSortedArray
{
    public static void Main()
    {
        int[] arr1 = { 1, 2, 5, 8 };
        int[] arr2 = { 3, 4, 6, 7 };
        Console.WriteLine(FindMedian(arr1, arr2));
    }

    public static double FindMedian(int[] nums1, int[] nums2)
    {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        if (n1 > n2) return FindMedian(nums2, nums1);

        int low = 0;
        int high = n1;
        int leftSize = (n1 + n2 + 1) / 2;
        while (low <= high)
        {
            int mid1 = (low + high) / 2;
            int mid2 = leftSize - mid1;

            int l1 = mid1 == 0 ? Int32.MinValue : nums1[mid1 - 1];
            int r1 = mid1 == n1 ? Int32.MaxValue : nums1[mid1];

            int l2 = mid2 == 0 ? Int32.MinValue : nums2[mid2 - 1];
            int r2 = mid2 == n2 ? Int32.MaxValue : nums2[mid2];

            if (l1 <= r2 && l2 <= r1)
            {
                if ((n1 + n2) % 2 == 0)
                {
                    return ((double)Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                }
                else
                {
                    return Math.Max(l1, l2);
                }
            }
            else if (l1 > r2)
            {
                high = mid1 - 1;
            }
            else
            {
                low = mid1 + 1;
            }
        }
        return 0;
    }
}
