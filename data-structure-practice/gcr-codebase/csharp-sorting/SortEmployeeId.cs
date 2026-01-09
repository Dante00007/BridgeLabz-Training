

class SortEmployeeId
{
    private void InsertionSort(int[] arr)
    {
        for(int i=1;i<arr.Length;i++)
        {
            int key=arr[i];
            int j=i-1;
            while(j>=0 && arr[j]>key)
            {
                arr[j+1]=arr[j];
                j--;
            }
            arr[j+1]=key;
        }
    }
    private void Print(int[] arr)
    {
        foreach(int item in arr)
            Console.Write(item+" ");
        Console.WriteLine();
    }
    public static void Main()
    {
        
        SortEmployeeId obj=new SortEmployeeId();

        Console.WriteLine("Enter number of employees:");
        int n=int.Parse(Console.ReadLine());
        int[] emp=new int[n];
        Console.WriteLine("Enter employee IDs:");
        for(int i=0;i<n;i++)
            emp[i]=int.Parse(Console.ReadLine());

        Console.WriteLine("\nBefore Sorting");
        obj.Print(emp);
        obj.InsertionSort(emp);
        Console.WriteLine("\nAfter Sorting");
        obj.Print(emp);
    }
}