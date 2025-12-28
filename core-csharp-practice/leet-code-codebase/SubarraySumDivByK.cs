
class SubarraySumDivByK
{
    static void Main()
    {
        int[] arr = { 4, 5, 0, -2, -3, 1 };
        int k = 5;
        Console.WriteLine(SubArray(arr, k)); //7

        int []nums = {5};
        k = 9;
        Console.WriteLine(SubArray(nums,k)); //0
    }

    public static int SubArray(int[] arr, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;
        int count = 0;
        map.Add(0, 1);
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            int rem = sum % k;
            if (rem < 0)
                rem += k;
                
            if (map.ContainsKey(rem)){
                count += map[rem];
                map[rem]++; 
            }
            else
                map.Add(rem, 1);
        }
        return count;
    }
}