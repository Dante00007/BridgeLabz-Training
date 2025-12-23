

class Sum{
	static void Main(){
		double[] arr = new double[10];
		int i=0;
		while(true){
			Console.WriteLine("Enter Number");
			arr[i] = Convert.ToDouble(Console.ReadLine());
			if(arr[i]<=0 || i==9)break;
			i++;
		}
        double total = 0.0;
        for(int j=0;j<arr.Length;j++){
            total += arr[j];
        }
        Console.WriteLine("Total is {0}",total);
    }
}