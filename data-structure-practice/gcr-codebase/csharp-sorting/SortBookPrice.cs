using System;

class SortBookPrice
{
    private void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; i++)
            left[i] = arr[i];
        for (int i = mid; i < arr.Length; i++)
            right[i - mid] = arr[i];

        MergeSort(left);
        MergeSort(right);

      
        Merge(arr, left, right);
    }

    private void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

       
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

      
        while (j < right.Length)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }

    private void Print(int[] arr)
    {
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        SortBookPrice obj = new SortBookPrice();

        Console.WriteLine("Enter number of Books:");
        int n = int.Parse(Console.ReadLine());
        int[] prices = new int[n];
        
        Console.WriteLine("Enter Books Prices:");
        for (int i = 0; i < n; i++)
            prices[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting");
        obj.Print(prices);
        
        obj.MergeSort(prices);
        
        Console.WriteLine("\nAfter Sorting");
        obj.Print(prices);
    }
}