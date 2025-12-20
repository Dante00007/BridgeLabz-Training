class FarCel{
	static void Main(){
		Console.WriteLine("Enter the value of Fahrenheit");
		int far=Convert.ToInt32(Console.ReadLine());
        int cel=(far-32)*5/9;
        Console.WriteLine("The {0} Fahrenheit is {1} Celsius",far,cel);
	}
}

