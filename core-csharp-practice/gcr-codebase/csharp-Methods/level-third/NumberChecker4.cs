

class NumberChecker4{
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
    public static bool IsPrime(int num){
        if(num<=1) return false;
        for(int i=2;i<=num/2;i++){
            if(num%i==0)
                return false;
        }
        return true;
    }
    public static bool IsNeon(int num){
        int []digits = StoreDigits(num);
        int sum=0;
        for(int i=0;i<digits.Length;i++){
            sum+=(int)Math.Pow(digits[i],2);
        }
        if(sum==num)
            return true;
        return false;
    }
    public static bool IsSpy(int num){
        int []digits = StoreDigits(num);
        int sum=0;
        int product=1;
        for(int i=0;i<digits.Length;i++){
            sum+=digits[i];
            product*=digits[i];
        }
        if(sum==product)
            return true;
        return false;
    }
    public static bool IsAutomorphic(int num){
        int square=num*num;
        int rem=square%10;
        if(rem==num)
            return true;
        return false;
    }
    public static bool IsBuzz(int num){
        if(num%7==0 || num%10==7)
            return true;
        return false;
    }
    static void Main(){
        Console.Write("Enter Number ");
        int num=Convert.ToInt32(Console.ReadLine());
        bool prime=IsPrime(num);
        bool neon=IsNeon(num);
        bool spy=IsSpy(num);
        bool automorphic=IsAutomorphic(num);
        bool buzz=IsBuzz(num);
        Console.WriteLine("Is {0} a prime number? {1}",num,prime);
        Console.WriteLine("Is {0} a neon number? {1}",num,neon);
        Console.WriteLine("Is {0} a spy number? {1}",num,spy);
        Console.WriteLine("Is {0} an automorphic number? {1}",num,automorphic);
        Console.WriteLine("Is {0} a buzz number? {1}",num,buzz);
    }
}