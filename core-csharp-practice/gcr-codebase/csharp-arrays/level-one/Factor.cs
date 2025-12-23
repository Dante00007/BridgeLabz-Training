/*

Find the factors of the number and save them in an array. For this create integer variable maxFactor and initialize to 10, factors array of size maxFactor and index variable to reflect the index of the array. 
To find factors loop through the numbers from 1 to the number, find the factors, and add them to the array element by incrementing the index. If the index is equal to maxIndex, then need factors array to store more elements
To store more elements, reset the maxIndex to twice its size, use the temp array to store the elements from the factors array, and eventually assign the factors array to the temp array
Finally, Display the factors of the number
*/

class Factor
{
    static void Main()
    {
        Console.Write("Enter Number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if(num % i == 0)
            {
                factors[index++] = i;
                if(index >= maxFactor)
                {
                    maxFactor *= 2;
                    int[] tempFactors = new int[maxFactor];
                    Array.Copy(factors,tempFactors,maxFactor);
                    factors = tempFactors;
                }
            }
        }
        Console.WriteLine("Factors of {0} are :",num);
        for(int i=0;i<factors.Length;i++)
        {
            if (factors[i] == 0) break;
            Console.Write("{0} ",factors[i]);
            
        }
    }
}