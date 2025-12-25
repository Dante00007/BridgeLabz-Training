

class NumberChecker3{
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
    public static int[] ReverseDigits(int[] digits){
        int n = digits.Length;
        int[] rev=new int[n];
        for(int i=0;i<n;i++){
            rev[i]=digits[n-1-i];
        }
        return rev;
    }
    public static bool AreEqual(int[] digits1,int[] digits2){
        for(int i=0;i<digits1.Length;i++){
            if(digits1[i]!=digits2[i]){
                return false;
            }
        }
        return true;
    }
    public static bool IsPalindrome(int []digits){
        int i=0;
        int j=digits.Length-1;
        while(i<j){
            if(digits[i]!=digits[j]){
                return false;
            }
            i++;j--;
        }
        return true;
    }
    public static bool IsDuckNumber(int []digits){
        for(int i=0;i<digits.Length;i++){
            if(digits[i]!=0){
                return true;
            }
        }
        return false;
    }
    public static void PrintDigits(int[] digits){
        for(int i=0;i<digits.Length;i++){
            Console.Write(digits[i]+" ");
        }
        Console.WriteLine();
    }
    static void Main(){
        Console.Write("Enter Number 1 ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number 2 ");
        int num2=Convert.ToInt32(Console.ReadLine());

        int[] digits1=StoreDigits(num1);
        int[] digits2=StoreDigits(num2);

        int[] rev=ReverseDigits(digits1);
        Console.Write("Printing the number in reverse ");
        PrintDigits(rev);
        
        if(AreEqual(digits1,rev)){
            Console.WriteLine("The number is a palindrome number");
        }else{
            Console.WriteLine("The number is not a palindrome number");
        }
        if(IsDuckNumber(digits2)){
            Console.WriteLine("The number is a duck number");
        }else{
            Console.WriteLine("The number is not a duck number");
        }
    }
}