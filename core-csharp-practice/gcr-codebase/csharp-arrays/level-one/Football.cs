class Football
{
    static void Main()
    {
        double[] heights = new double[11];
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter Height ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        double sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += item;
        }
        Console.WriteLine(sum);
        Console.WriteLine("Mean Height ", sum / heights.Length);
    }
}
