
class Pattern132 {
    public static bool Find132pattern(int[] nums) {
        int n = nums.Length;  
        Stack<int> stack = new Stack<int>();
        int k = int.MinValue;
        
        for(int i=n-1;i>=0;i--){
            if(nums[i]<k) return true;
            while(stack.Count>0 && nums[i]>stack.Peek()){
                k = stack.Pop();
            }
            stack.Push(nums[i]);
        }
        return false;   
    }  
    public static void Main(string[] args)
    {
        int []nums= {3,1,4,2};
        Console.WriteLine(Find132pattern(nums));
    }
}
    
    