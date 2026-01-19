
using System;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] L = new int[n1];
        int[] R = new int[n2];
        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j]) arr[k++] = L[i++];
            else arr[k++] = R[j++];
        }
        while (i < n1) arr[k++] = L[i++];
        while (j < n2) arr[k++] = R[j++];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = (low - 1);
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;
        return i + 1;
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] originalArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            originalArr[i] = int.Parse(Console.ReadLine());
        }

        int[] arr1 = (int[])originalArr.Clone();
        int[] arr2 = (int[])originalArr.Clone();
        int[] arr3 = (int[])originalArr.Clone();

        DateTime startTime = DateTime.Now;
        BubbleSort(arr1);
        DateTime endTime = DateTime.Now;
        Console.Write("Bubble Sort: ");
        Console.WriteLine((endTime - startTime).TotalMilliseconds + " ms");

        startTime = DateTime.Now;
        MergeSort(arr2, 0, n - 1);
        endTime = DateTime.Now;
        Console.Write("Merge Sort: ");
        Console.WriteLine((endTime - startTime).TotalMilliseconds + " ms");

        startTime = DateTime.Now;
        QuickSort(arr3, 0, n - 1);
        endTime = DateTime.Now;
        Console.Write("Quick Sort: ");
        Console.WriteLine((endTime - startTime).TotalMilliseconds + " ms");
    }
}