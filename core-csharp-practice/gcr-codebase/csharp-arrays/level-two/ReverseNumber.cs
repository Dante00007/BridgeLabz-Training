
class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int tempNum = num;

        int cnt = 0;
        while (tempNum != 0)
        {
            tempNum /= 10;
            cnt++;
        }
        int[] arr = new int[cnt];
        for (int i = 0; i < cnt; i++)
        {
            arr[i] = num % 10;
            num /= 10;
        }

        for (int j = 0; j < cnt; j++)
        {
            Console.Write(arr[j]);
        }
    }
}