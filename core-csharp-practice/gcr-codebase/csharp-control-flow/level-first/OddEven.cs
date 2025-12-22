

class OddEven{
	static void Main(){
        Console.WriteLine("Enter any number");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=num;i++){
            if(i%2==0){
                Console.WriteLine("{0} is Even",i);
            }
            else{
                Console.WriteLine("{0} is Odd",i);
            }
        }
	}
}