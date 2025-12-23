

class OddEven
{
    static void Main()
    {
        Console.Write("Enter any number ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("Error");
            return;
        }
        else
        {
            int[] evenArray = new int[num / 2 + 1];
            int[] oddArray = new int[num / 2 + 1];
            int evenIndex = 0;
            int oddIndex = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                    oddArray[oddIndex++] = i;
                else
                    evenArray[evenIndex++] = i;
            }
            Console.WriteLine("Odd Array : ");
            for (int i = 0; i < oddArray.Length; i++)
                Console.Write(oddArray[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Even Array : ");
            for (int i = 0; i < evenArray.Length; i++)
                Console.Write(evenArray[i] + " ");
        }
    }
}