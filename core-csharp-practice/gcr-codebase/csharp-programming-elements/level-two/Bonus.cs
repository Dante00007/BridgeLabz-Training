

class Bonus{
	static void Main(){
		int salary = Convert.ToInt32(Console.ReadLine());
		int bonus = Convert.ToInt32(Console.ReadLine());
		int income = salary + bonus;
		Console.WriteLine("The salary is INR {0} and bonus is INR {1}. Hence Total Income is INR {2}",salary,bonus,income);
	}
}