

class SumTillZero{
    static void Main(){
        double total = 0.0;
        double num = Convert.ToDouble(Console.ReadLine());
        while(num!=0){
            total += num;
            num = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("The sum is {0}",total);
    }
}