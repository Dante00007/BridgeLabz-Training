class QuoRem
{
	static void Main()
	{
		Console.WriteLine("Enter the first number");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		int num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}", (num1 / num2), (num1 % num2), num1, num2);
	}
}