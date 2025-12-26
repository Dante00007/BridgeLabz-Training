

class IndexOfRange2 {
    static void Main()
    {
        int[] arr = new int[3]{1,2,3};
     
        try
        {
            Console.WriteLine(arr[3]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}