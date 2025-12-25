
class Factors
{
    public static int[] FindFactors(int n)
    {
        int noOfFactors = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
                noOfFactors++;
        }
        int[] arr = new int[noOfFactors];
        int index=1;
        int temp=1;
        while(temp<=n/2)
        {
            if(n%temp==0){
                arr[index] = temp;
                index++;
            }
            temp++;
        }
        return arr; 
    }
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] factors = FindFactors(num);

        int sum = CalculateSum(factors);
        int product = CalculateProduct(factors);
        int sumOfSquares = CalculateSumOfSquares(factors);
        Console.WriteLine("The Sum is {0}, The Product is {1}, The Sum of Squares is {2}",sum,product,sumOfSquares);
    }
}