
class FizzBuzz{
    static void Main(){
        int num=Convert.ToInt32(Console.ReadLine());
        string[] result=new string[num+1];
        for(int i=0;i<=num;i++){
            if(i%3==0 && i%5!=0){
                result[i-1]="Fizz";
            }else if(i%5==0 && i%3!=0){
                result[i-1]="Buzz";
            }else if(i%3==0 && i%5==0){
                result[i-1]="FizzBuzz";
            }else{
                result[i-1]=i.ToString();
            }   
        }
        for(int i=0;i<=n;i++){
            Console.WriteLine("Position "+(i+1)+" = "+result[i]);
        }
    }
}