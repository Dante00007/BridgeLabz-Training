
class Youngest{
	public static void Main(){
		int amarAge = Convert.ToInt32(Console.ReadLine());
		int akbarAge = Convert.ToInt32(Console.ReadLine());
		int anthonyAge = Convert.ToInt32(Console.ReadLine());

        int amarHeight = Convert.ToInt32(Console.ReadLine());
        int akbarHeight = Convert.ToInt32(Console.ReadLine());
        int anthonyHeight = Convert.ToInt32(Console.ReadLine());

        if(amarAge < akbarAge && amarAge < anthonyAge){
            Console.WriteLine("Amar is the youngest");
        }else if (akbarAge < amarAge && akbarAge < anthonyAge) {
            Console.WriteLine("Akbar is the youngest");
        }
        else{
            Console.WriteLine("Anthony is the youngest");
        }

        if(amarHeight > akbarHeight && amarHeight > anthonyHeight){
                Console.WriteLine("Amar is the tallest");
        }else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight) {
                Console.WriteLine("Akbar is the tallest");
        }
        else{
                Console.WriteLine("Anthony is the tallest");
        }
    }
}