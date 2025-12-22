
class Smallest3No{
	static void Main(){
        Console.WriteLine("Enter first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter third number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if(num1<num2 && num1<num3)
            Console.WriteLine("The first number is the smallest number");
        else if(num2<num1 && num2<num3)
            Console.WriteLine("The second number is the smallest number");
        else
            Console.WriteLine("The third number is the smallest number");
	}
}
