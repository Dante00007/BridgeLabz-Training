
class SumUntilZero2{
	static void Main(){
		int num,sum=0;
		while(true){
			Console.WriteLine("Enter Number");
			num=int.Parse(Console.ReadLine());
			if(num<=0)break;
			sum+=num;
		}
		Console.WriteLine(sum);
	}
}