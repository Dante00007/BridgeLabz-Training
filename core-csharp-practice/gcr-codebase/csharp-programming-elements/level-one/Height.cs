

class Height{
	public static void Main(string[] args){
        double height = Convert.ToDouble(Console.ReadLine());
        double feet = height/30.48;
        double inches = height/2.54;
        Console.WriteLine("Your Height in cm is "+height+" while in feet is "+feet+" and inches is "+inches);
	}
}