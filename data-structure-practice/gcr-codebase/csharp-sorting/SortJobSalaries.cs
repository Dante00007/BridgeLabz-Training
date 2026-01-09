using System;

class SortJobSalaries
{
    private void HeapSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            Heapify(arr, i, 0);
        }
    }

    private void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
            largest = left;

        if (right < n && arr[right] > arr[largest])
            largest = right;

        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            Heapify(arr, n, largest);
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
        SortJobSalaries obj = new SortJobSalaries();

        Console.WriteLine("Enter number of Applicants:");
        int n = int.Parse(Console.ReadLine());
        int[] salaries = new int[n];

        Console.WriteLine("Enter Salary Demands:");
        for (int i = 0; i < n; i++)
            salaries[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting");
        obj.Print(salaries);

        obj.HeapSort(salaries);

        Console.WriteLine("\nAfter Sorting");
        obj.Print(salaries);
    }
}