
class TrappingRainWater {
    public static int Trap(int[] height) {

        int left = 1;
        int right = height.Length - 2;

        int lmax = height[left-1];
        int rmax = height[right+1];
        int water = 0;

        while (left <= right) {
            if (lmax <= rmax) {
                int waterInBlock = Math.Max(0,lmax-height[left]);
                water+=waterInBlock;

                lmax = Math.Max(lmax, height[left]);
                left++;
            } else {
                int waterInBlock = Math.Max(0,rmax-height[right]);
                water+=waterInBlock;

                rmax = Math.Max(rmax, height[right]);
               
                right--;
            }
        }
        return water;
    }
     static void Main() {

        //height = [0,1,0,2,1,0,1,3,2,1,2,1]
        int [] height={0,1,0,2,1,0,1,3,2,1,2,1};

        Console.WriteLine(Trap(height)); //6
        
    }
}