
class PosNeg
{
    public static int IsPositive(int num)
    {
        return (num >= 0);
    }
    public static bool IsEven(int num)
    {
        return (num % 2 == 0);
    }
    static int Compare(int num1,int num2)
    {
        if(num1>num2)
            return 1;
        else if(num1==num2)
            return 0;
        else
            return -1;
    }
    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter five numbers");
        for(int i=0;i<arr.Length;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        for(int j=0;j<arr.Length;j++)
        {
            if(IsPositive(arr[j]))
            {
                if(IsEven(arr[j]))
                    Console.WriteLine("{0} is Positive Even Number",arr[j]);
                else
                    Console.WriteLine("{0} is Positive Odd Number", arr[j]);
            }else
                Console.WriteLine("{0} is Negative Number", arr[j]);
        }
        Console.WriteLine("Comparing first and last element of the array");
        Console.WriteLine("Result : {0}", Compare(arr[0],arr[arr.Length-1]));
    }
}