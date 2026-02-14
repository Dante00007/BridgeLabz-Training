class ArrayHandler
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30 };
        try
        {
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Value at index {index}: {arr[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}