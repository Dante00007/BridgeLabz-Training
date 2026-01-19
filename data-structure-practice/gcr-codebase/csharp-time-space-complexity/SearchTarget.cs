
class SearchTarget
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        DateTime startTime = DateTime.Now;
        Console.WriteLine(LinearSearch(arr, 5));
        DateTime endTime = DateTime.Now;
        Console.Write("Linear Search: ");
        Console.WriteLine((endTime - startTime).TotalMilliseconds);

        startTime = DateTime.Now;
        Console.WriteLine(BinarySearch(arr, 5));
        endTime = DateTime.Now;
        Console.Write("Binary Search: ");
        Console.WriteLine((endTime - startTime).TotalMilliseconds);
    }
}