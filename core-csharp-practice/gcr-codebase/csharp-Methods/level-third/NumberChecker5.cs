

class NumberChecker5{
    public static int[] FindFactors(int num){
        int cnt = 0;
        for(int i=1;i<=num/2;i++){
            if(num%i==0){
                cnt++;
            }
        }
        int[] factors = new int[cnt];
        int index = 0;
        for(int i=1;i<=num/2;i++){
            if(num%i==0){
                factors[index++] = i;
            }
        }
        return factors;
    }
    public static int GreatestFactor(int[] factors){
        int max = factors[0];
        for(int i=1;i<factors.Length;i++){
            if(factors[i]>max){
                max = factors[i];
            }
        }
        return max;
    }
    public static int SumOfFactors(int[] factors){
        int sum = 0;
        for(int i=0;i<factors.Length;i++){
            sum += factors[i];
        }
        return sum;
    }
    public static int ProductOfFactors(int[] factors){
        int product = 1;
        for(int i=0;i<factors.Length;i++){
            product *= factors[i];
        }
        return product;
    }
    public static int ProductOfCubeOfFactors(int[] factors){
        int product = 1;
        for(int i=0;i<factors.Length;i++){
            product *= (int)Math.Pow(factors[i],3);
        }
        return product;
    }
    public static bool PerfectNumber(int[] factors,int num){
        int sum = SumOfFactors(factors);

        if(sum==num){
            return true;
        }
        return false;
    }
    public static bool AbundantNumber(int[] factors,int num){
        int sum = SumOfFactors(factors);
    
        if(sum>num){
            return true;
        }
        return false;
    }
    public static bool DeficientNumber(int[] factors,int num){
        int sum = SumOfFactors(factors);
    
        if(sum<num){
            return true;
        }
        return false;
    }
    public static int[] FindDigits(int num){
        int cnt = 0;
        while(num>0){
            num = num/10;
            cnt++;
        }
        int[] digits = new int[cnt];
        int index = 0;
        while(num>0){
            digits[index++] = num%10;
            num = num/10;
        }
        return digits;  
    }
    public static int Factorial(int digit){
        int fact = 1;
        for(int i=1;i<=digit;i++){
            fact *= i;
        }
        return fact;
    }
    public static bool StrongNumber(int num){
        int [] digits = FindDigits(num);
        int sum = 0;
        for(int i=0;i<digits.Length;i++){
            sum += Factorial(digits[i]);
        }
        if(sum==num){
            return true;
        }
        return false;
    }
    static void Main(){
        Console.Write("Enter Number ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(num);
        int maxFactor = GreatestFactor(factors);
        int sumOfFactors = SumOfFactors(factors);
        int productOfFactors = ProductOfFactors(factors);
        int productOfCubeOfFactors = ProductOfCubeOfFactors(factors);

        bool perfectNumber = PerfectNumber(factors,num);
        bool abundantNumber = AbundantNumber(factors,num);
        bool deficientNumber = DeficientNumber(factors,num);

        bool strongNumber = StrongNumber(num);

        Console.WriteLine("Max Factor of {0} is {1}",num,maxFactor);
        Console.WriteLine("Sum of Factors of {0} is {1}",num,sumOfFactors);
        Console.WriteLine("Product of Factors of {0} is {1}",num,productOfFactors);
        Console.WriteLine("Product of Cube of Factors of {0} is {1}",num,productOfCubeOfFactors);
        Console.WriteLine("Is {0} a perfect number? {1}",num,perfectNumber);
        Console.WriteLine("Is {0} an abundant number? {1}",num,abundantNumber);
        Console.WriteLine("Is {0} a deficient number? {1}",num,deficientNumber);
        Console.WriteLine("Is {0} a strong number? {1}",num,strongNumber);
    }
}