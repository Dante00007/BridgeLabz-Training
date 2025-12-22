
class Armstrong{
    static void Main(){
        int sum=0;
        Console.WriteLine("Enter any number");
        int num=Console.ToInt32(Console.ReadLine());
        int temp=num;
        while(temp!=0){
            int rem=temp%10;
            sum+=(rem*rem*rem);
            temp/=10;
        }
        if(num==sum)
            Console.WriteLine("{0} is armstrong number",num);
        else
            Console.WriteLine("{0} is not armstrong number",num);
    }
}