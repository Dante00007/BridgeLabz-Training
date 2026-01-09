class SortStudentMarks
{
    private void BubbleSort(int[] arr)
    {
        
        for (int i = 0; i < arr.Length; i++)
        {
            bool swapped = false;
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    private void PrintMarks(int[] arr)
    {
        foreach(int item in arr)
            Console.Write(item+" ");
        Console.WriteLine();
    }
     static void Main(string [] args)
    {
        SortStudentMarks obj = new SortStudentMarks();

        Console.WriteLine("Enter the number of subjects");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] marks = new int[n];
        Console.WriteLine("Enter the student marks");
        for (int i = 0; i < n; i++)
            marks[i] = Convert.ToInt32(Console.ReadLine());
    
        
        Console.WriteLine("\nBefore Sorting");
        obj.PrintMarks(marks);
        obj.BubbleSort(marks);
        Console.WriteLine("\nAfter Sorting");
        obj.PrintMarks(marks);
    }
}