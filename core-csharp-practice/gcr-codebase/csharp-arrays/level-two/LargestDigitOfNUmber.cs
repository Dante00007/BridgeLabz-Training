/*
Create a program to store the digits of the number in an array and find the largest and second largest element of the array.
Hint => 
Create a number variable and take user input. 
Define an array to store the digits. Set the size of the array to maxDigit variable initially set to 10
Create an integer variable index with the value 0 to reflect the array index.
Use a loop to iterate until the number is not equal to 0.
Remove the last digit from the number in each iteration and add it to the array.
Increment the index by 1 in each iteration and if the index count equals maxDigit then break out of the loop and the remaining digits are not added to the array
Define variable to store largest and second largest digit and initialize it to zero
Loop through the array and use conditional statements to find the largest and second largest number in the array
Finally display the largest  and second-largest number
*/

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
