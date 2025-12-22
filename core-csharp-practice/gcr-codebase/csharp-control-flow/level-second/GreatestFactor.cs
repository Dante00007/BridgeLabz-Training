
class GreatestFactor{
    static void Main(){
        int num=Convert.ToInt32(Console.ReadLine());
        int greatestfactor=1;
        for(int i=num-1;i>=1;i--){
            if(num%i==0){
                greatestfactor=i;
                break;
            }
        }
        Console.WriteLine(greatestfactor);
    }
}