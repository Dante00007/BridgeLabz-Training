

class ChangeDimension
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of rows and columns ");
        int rows = Convert.ToInt32(Console.ReadLine());
        int cols = Convert.ToInt32(Console.ReadLine());
        int[] arr1D = new int[rows * cols];
        int[,] arr2D = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element ");
                arr2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr1D[index++] = arr2D[i, j];
            }
        }
        for (int i = 0; i < arr1D.Length; i++)
        {
            Console.Write(arr1D[i] + " ");
        }
    }
}
