class Random
{
    public static double[] FindAverageMinMax(int[] numbers)
    {
        double avg = 0;
        int min = Int32.MaxValue;
        int max = Int32.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];
            if (numbers[i] > max)
                max = numbers[i];
            avg += numbers[i];
        }
        avg /= numbers.Length;
        double[] res = new double[3];
        res[0] = avg;
        res[1] = min;
        res[2] = max;
        return res;
    }
    static int[] Generate4DigitRandom(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = GetRandom();
        return arr;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Size");

        int[] arr = Generate4DigitRandom(4);


        double[] result = FindAverageMinMax(arr);
        Console.WriteLine("Average : {0}, Minimum : {1}, Maximum : {2}", result[0], result[1], result[2]);
    }
}