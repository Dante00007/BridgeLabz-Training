
class Largest{
	static void Main(){
		int num1,num2,num3;
		Console.WriteLine("Enter 3 numbers");
		num1=Convert.ToInt32(Console.ReadLine());
		num2=Convert.ToInt32(Console.ReadLine());
		num3=Convert.ToInt32(Console.ReadLine());
        if(num1>num2 && num1>num3)
            Console.WriteLine("The first number is the largest number");
        else if(num2>num1 && num2>num3)
            Console.WriteLine("The second number is the largest number");
        else
            Console.WriteLine("The third number is the largest number");
    }
}   