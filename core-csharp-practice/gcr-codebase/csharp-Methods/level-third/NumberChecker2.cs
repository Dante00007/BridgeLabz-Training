
class NumberChecker2{
    public static int CountDigits(int num){
        int count=0;
        while(num!=0){
            num/=10;
            count++;
        }
        return count;
    }

    public static int[] StoreDigits(int num){
        int count=CountDigits(num);
        int[] digits=new int[count];
        int index=count-1;
        while(num!=0){
            digits[index]=num%10;
            num/=10;
            index--;
        }
        return digits;
    }
    public static int SumOfDigits(int []digits){
        int sum=0;
        int i = 0;
        while(i<digits.Length){
            sum+=digits[i];
            i++;
        }
        return sum;
    }
    public static int SumOfSquares(int []digits){
        int sum=0;
        int i = 0;
        while(i<digits.Length){
            sum+=(int)Math.Pow(digits[i],2);
            i++;
        }
        return sum;
    }
    public static bool IsHarshadNumber(int num){
        int [] digits=StoreDigits(num);
        int sum=SumOfDigits(digits);
        if(num%sum==0)
            return true;
        return false;
    }
    public static int[,] FindFrequency(int num){
        int [] digits=StoreDigits(num);
        int [,] freq = new int[10,2];
        for(int i=0;i<digits.Length;i++){
            freq[digits[i],0]=digits[i];
            freq[digits[i],1]++;
        }
        return freq;
    }
    static void Main(){
        Console.Write("Enter Number ");
        int num=Convert.ToInt32(Console.ReadLine());

        int [] digits=StoreDigits(num);
        int sum=SumOfDigits(digits);
        int sumOfSquares=SumOfSquares(digits);
        bool harshad=IsHarshadNumber(num);
        int [,] freq=FindFrequency(num);
        Console.WriteLine("The sum of digits of {0} is {1}",num,sum);
        Console.WriteLine("The sum of squares of digits of {0} is {1}",num,sumOfSquares);
        Console.WriteLine("Is {0} a Harshad number? {1}",num,harshad);
    }
}