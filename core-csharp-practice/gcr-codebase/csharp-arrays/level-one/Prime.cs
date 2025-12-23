
class Prime
{
	public static void Main(){
		int []arr=new int[5];
        int n = arr.Length;
        for(int i=0;i<n;i++){
			arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int j=0;j<n;j++){
            if(arr[j]>0){
                if(arr[j]%2==0)
                    Console.WriteLine("{0} is Positive Even Number",arr[j]);
                else
                    Console.WriteLine("{0} is Positive Odd Number",arr[j]);
            }else if(arr[j]<0){
                 Console.WriteLine("{0} is Negative Number",arr[j]);
            }else{
                Console.WriteLine("{0} is Zero ",arr[j]);
            }   
        }
        if(arr[0]>arr[n-1]){
            Console.WriteLine("{0} is greater than {1}",arr[0],arr[n-1]);
        }else if(arr[0]<arr[arr.Length-1]){
            Console.WriteLine("{0} is less than {1}",arr[0],arr[n-1]);
        }else{
            Console.WriteLine("{0} is equal to {1}",arr[0],arr[n-1]);
        }

    }
}