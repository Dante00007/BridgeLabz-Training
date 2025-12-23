

class LargestModify {
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] digits = new int[5];
        int maxDigit=5;
        int index = 0;
        while(num!=0)
        {
            digits[index]=num%10;
            num/=10;
            index++;
            if(index==maxDigit){
                maxDigit+=10;
                int[] temp=new int[maxDigit];
                for(int j=0;j<index;j++){
                    temp[j]=digits[j];
                }
                digits=temp;
            }
        }

        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] < largest && arr[i] > secondLargest)
                secondLargest = arr[i];
        }
        Console.WriteLine("The largest digit is {0}", largest);
        Console.WriteLine("The second largest digit is {0}", secondLargest);

    }
}