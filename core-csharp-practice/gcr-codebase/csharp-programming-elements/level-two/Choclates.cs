

class Choclates{
	static void Main(){
		Console.WriteLine("Enter Number Of Chocolates");
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Number Of Children");
		int m=int.Parse(Console.ReadLine());
        int a=n/m;
        int b=n%m;
        Console.WriteLine("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}",a,b);
	}
}