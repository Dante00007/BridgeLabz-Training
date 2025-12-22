
class Count{
	static void Main(){
        int counter = Convert.ToInt32(Console.ReadLine());
        while(counter>1)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine(counter);
	}
 }