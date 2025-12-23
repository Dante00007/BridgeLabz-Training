
class Frequency
{
    static void Main()
    {

        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        int tempNum = num;
        int cnt = 0;
        while (tempNum != 0)
        {
            tempNum /= 10;
            cnt++;
        }

        int[] arr = new int[cnt];

        int i = cnt - 1;
        while (i >= 0)
        {
            arr[i] = num % 10;
            num /= 10;
            i--;
        }

        int[] freq = new int[10];
        for (int j = 0; j < arr.Length; j++)
        {
            freq[arr[j]]++;
        }

        for (int k = 0; k < freq.Length; k++)
        {
            Console.WriteLine("Frequency of {0} is {1}", k, freq[k]);
        }
    }
}