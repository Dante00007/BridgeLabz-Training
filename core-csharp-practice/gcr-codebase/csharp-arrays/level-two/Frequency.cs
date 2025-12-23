/*
Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
Hint => 
Take the input for a number
Find the count of digits in the number
Find the digits in the number and save them in an array
Find the frequency of each digit in the number. For this define a frequency array of size 10, Loop through the digits array, and increase the frequency of each digit
Display the frequency of each digit in the number
*/
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