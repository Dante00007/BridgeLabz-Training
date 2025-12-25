

class NumberChecker{
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

    public static bool IsDuckNumber(int num){
        int[] digits=StoreDigits(num);
        for(int i=0;i<digits.Length;i++){
            if(digits[i]!=0)
                return true;
        }
        return false;
    }

    public static bool IsArmstrongNumber(int num){
        int[] digits=StoreDigits(num);
        int sum=0;
        for(int i=0;i<digits.Length;i++){
            sum+=(int)Math.Pow(digits[i],digits.Length);
        }
        if(sum==num)
            return true;
        return false;
    }

    public static int[] FindLargest(int[] digits){
        int[] largest=new int[2];
        largest[0]=Int32.MinValue;
        largest[1]=Int32.MinValue;
        for(int i=0;i<digits.Length;i++){
            if(digits[i]>largest[0]){
                largest[1]=largest[0];
                largest[0]=digits[i];
            }else if(digits[i]>largest[1] && digits[i]<largest[0]){
                largest[1]=digits[i];
            }
        }
        return largest;
    }
    public static int[] FindSmallest(int[] digits){
        int [] smallest=new int[2];
        smallest[0]=Int32.MaxValue;
        smallest[1]=Int32.MaxValue;
        for(int i=0;i<digits.Length;i++){
            if(digits[i]<smallest[0]){
                smallest[1]=smallest[0];
                smallest[0]=digits[i];
            }else if(digits[i]<smallest[1] && digits[i]>smallest[0]){
                smallest[1]=digits[i];
            }
        }
        return smallest;
    }

    static void Main(){
        Console.Write("Enter Number ");
        int num=Convert.ToInt32(Console.ReadLine());
        int[] digits=StoreDigits(num);
        int[] largest=FindLargest(digits);
        int[] smallest=FindSmallest(digits);
        Console.WriteLine("The largest number is {0} and the second largest number is {1}",largest[0],largest[1]);
        Console.WriteLine("The smallest number is {0} and the second smallest number is {1}",smallest[0],smallest[1]);
    }
}