
class DivisibleBy5{
	static void Main(){
		Console.WriteLine("Enter Number");
		int num = Convert.ToInt32(Console.ReadLine());
        if(num%5==0)
			Console.WriteLine("{0} is divisible by 5",num);
        else
            Console.WriteLine("{0} is not divisible by 5",num);
	}
}
