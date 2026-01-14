using System;

class Solution
{
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            
            if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
            {
                return i + 1;
            }
        }

        return n + 1;
    }
    static void Main()
    {
        int[] numbers = { 3, 4, -1, 1 };
        int target = 4;

        int missing = FindFirstMissingPositive(numbers);
        Console.WriteLine("First Missing Positive: " + missing);

        Array.Sort(numbers);
        int targetIndex = BinarySearch(numbers, target);
        Console.WriteLine("Target Index after sorting: " + targetIndex);
    }

    

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            
            if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}