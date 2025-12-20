
class Calculator{
	public static void Main(string[] args){
		double num1,num2;
        Console.WriteLine("Enter first number");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second number");
        num2 = Convert.ToDouble(Console.ReadLine());
        double add = num1 + num2;
        double sub = num1 - num2;
        double mul = num1 * num2;
        double div = num1 / num2;
        Console.WriteLine("The addition of {0} and {1} is {2}",num1,num2,add);
        Console.WriteLine("The subtraction of {0} and {1} is {2}",num1,num2,sub);
        Console.WriteLine("The multiplication of {0} and {1} is {2}",num1,num2,mul);
        Console.WriteLine("The division of {0} and {1} is {2}",num1,num2,div);
    }
}