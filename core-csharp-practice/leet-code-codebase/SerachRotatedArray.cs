
class SearchRotatedArray
{
    static int search(int[] nums,int target)
    {
        int start=0;
        int end=nums.Length-1;
        int mid = start + (end - start) / 2;
        while(start<=end)
        {
           
            if(nums[mid]==target)
                return mid;

            if(nums[start]<=nums[mid])
            {
                if (target >= nums[start] && target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            else
            {
                if (target > nums[mid] && target <= nums[end])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            mid = start + (end - start) / 2;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int[] arr = { 4,5,6,7,0,1,2 };
        int target = 0;
        int result = search(arr,target);
        if (result == -1)
            Console.WriteLine("Element not found");
        else
            Console.WriteLine($"Element found at index :{result}");
    }
}