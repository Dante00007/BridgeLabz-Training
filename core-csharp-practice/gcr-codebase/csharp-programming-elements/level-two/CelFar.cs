class CelFar{
	static void Main(){
		Console.WriteLine("Enter the temperature in Celsius");
		double cel = Convert.ToDouble(Console.ReadLine());
        double far = (cel*9)/5 + 32;
        Console.WriteLine("The {0} Celsius is {1} Fahrenheit",cel,far);
	}
}