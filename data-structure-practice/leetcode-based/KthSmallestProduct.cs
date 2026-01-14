
class KthSmallestProduct {
    

    private long CountOfProductLessThanOrEqualK(int[] nums1, int[] nums2, long target) {
        long count = 0;
        foreach (int num1 in nums1) {
            if (num1 == 0) {
                if (target >= 0) count += nums2.Length;
                continue;
            }

            int low = 0;
            int high = nums2.Length - 1;
            int foundIndex = -1;

            if (num1 > 0) {
                while (low <= high) {
                    int mid = low + (high - low) / 2;
                    if ((long)num1 * nums2[mid] <= target) {
                        foundIndex = mid;
                        low = mid + 1;
                    } else {
                        high = mid - 1;
                    }
                }
                count += (foundIndex + 1);
            } else {
                while (low <= high) {
                    int mid = low + (high - low) / 2;
                    if ((long)num1 * nums2[mid] <= target) {
                        foundIndex = mid;
                        high = mid - 1;
                    } else {
                        low = mid + 1;
                    }
                }
                if (foundIndex != -1) count += (nums2.Length - foundIndex);
            }
        }
        return count;
    }
    public long KthSmallest(int[] nums1, int[] nums2, long k) {
        long left = -10000000000L;
        long right = 10000000000L;
        long result = left;

        while (left <= right) {
            long mid = left + (right - left) / 2;
            if (CountOfProductLessThanOrEqualK(nums1, nums2, mid) >= k) {
                result = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
        return result;
    }
    public static void Main(string[] args)
    {
        KthSmallestProduct obj = new KthSmallestProduct();

        int[] arr1 = { 2,5 };
        int[] arr2 = { 3,4 };
        long k = 2;
        Console.WriteLine(obj.KthSmallest(arr1,arr2,k));

    }
}