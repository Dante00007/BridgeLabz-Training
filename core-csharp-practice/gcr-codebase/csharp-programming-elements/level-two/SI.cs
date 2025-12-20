
class SI{
	static void Main(){
		int principal=Convert.ToInt32(Console.ReadLine());
        double rate=Convert.ToDouble(Console.ReadLine());
        int time=Convert.ToInt32(Console.ReadLine());
        double simpleInterest=(principal*rate*time)/100;
        Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}",simpleInterest,principal,rate,time);
	}
}