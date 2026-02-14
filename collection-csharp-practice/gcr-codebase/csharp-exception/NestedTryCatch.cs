class NestedTryCatch
{
    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30 };
        try
        {
            int idx = int.Parse(Console.ReadLine());
            int val = arr[idx];
            try
            {
                int div = int.Parse(Console.ReadLine());
                Console.WriteLine(val / div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid array index!");
        }
    }
}