
class PartitionArray {
    public int PartitionDisjoint(int[] A) {
        int n = A.Length;

        int ans = 1;
        int maxLeft = A[0];
        int maxRight = A[0];
        for(int i = 1; i < n; i++)
        {
            if(A[i] > maxLeft)
            {
                ans = i + 1;
                maxLeft = maxRight;
            }
            else
            {
                maxRight = Math.Max(maxRight,A[i]);
            }
        }
        return ans;
    }
    static void Main()
    {
        int []nums = {5,0,3,8,6};
        Console.WriteLine(PartitionDisjoint(nums));

        int []nums2 = {8,7,6,3,9,5,7,10};
        Console.WriteLine(PartitionDisjoint(nums2));
    }
}