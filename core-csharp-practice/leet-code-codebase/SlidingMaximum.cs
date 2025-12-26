using System;
using System.Collections.Generic;

class SlidingMaximum {

    public static int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        if (n == 0) return new int[0];
        
        List<int> ans = new List<int>();
   
        LinkedList<int> dq = new LinkedList<int>();

        for (int i = 0; i < n; i++) {
           
            if (dq.Count > 0 && dq.First.Value <= i - k) {
                dq.RemoveFirst();
            }
            
            while (dq.Count > 0 && nums[dq.Last.Value] <= nums[i]) {
                dq.RemoveLast();
            }
            
 
            dq.AddLast(i);
            if (i >= k - 1) {
                ans.Add(nums[dq.First.Value]);
            }
        }
        
        return ans.ToArray();
    }
    static void Main(string [] args){
        int[] nums = new int[] {1,3,-1,-3,5,3,6,7};
        int k = 3;
        int[] ans = MaxSlidingWindow(nums, k); //[3,3,5,5,6,7]
        for(int i=0;i<ans.Length;i++){
            Console.Write(ans[i]+" "); 
        }
    }
}