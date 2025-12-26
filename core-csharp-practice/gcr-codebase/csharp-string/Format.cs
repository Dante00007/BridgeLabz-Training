

class Format{
	 static void Main(){
		try{
			int num = int.Parse("Hello");
			Console.WriteLine(num);
		}
		catch(FormatException e){
			Console.WriteLine(e.Message);
		}
	}
}