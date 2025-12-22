
class Abundant{
    static void Main(){
        Console.WriteLine("Enter any number");
        int num=int.Parse(Console.ReadLine());
        int sum=0;
        for(int i=1;i<=num/2;i++){
            if(num%i==0){
                sum+=i;
            }
        }
        if(sum>num){
            Console.WriteLine("Abundant Number");
        }
        else{
            Console.WriteLine("Not an Abundant Number");
        }

    }
}