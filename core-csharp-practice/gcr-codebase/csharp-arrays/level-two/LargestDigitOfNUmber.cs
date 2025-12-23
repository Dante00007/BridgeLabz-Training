

class LargestDigitOfNUmber{
    static void Main(){
        int num = Convert.ToInt32(Console.ReadLine());
        int [] arr = new int[10];
        int index=0;
        while(num!=0){
            arr[index]=num%10;
            index++;
            num/=10;
            if(index==arr.Length)
                break;
        }
        int largest=0,secondLargest=0;
        for(int i=0;i<index;i++){
            if(arr[i]>largest){
                secondLargest=largest;
                largest=arr[i];
            }else if(arr[i]<largest && arr[i]>secondLargest)
                secondLargest=arr[i];
        }
        Console.WriteLine("The largest digit is {0}",largest);
        Console.WriteLine("The second largest digit is {0}",secondLargest);
    }
}
