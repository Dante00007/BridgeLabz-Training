
class Mul6To9{
	static void Main(){
		int num = Convert.ToInt32(Console.ReadLine());
        int []arr = new int[4];
		for(int i=6;i<=9;i++){
			arr[i-6]=num*i; 
		}
        for(int j=0;j<4;j++){
            Console.WriteLine(num+"*"+(j+6)+"="+arr[j]);
        }
	}
}