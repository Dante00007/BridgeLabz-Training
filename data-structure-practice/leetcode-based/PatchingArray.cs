class PatchingArray {
    private int MinPatches(int[] nums, int n) {
        long miss = 1;
        int i = 0;
        int count = 0;

        while(miss<=n){
            if(i < nums.Length && nums[i] <= miss){
                miss += nums[i];
                i++;
            }else{
                miss+=miss;
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        PatchingArray obj = new PatchingArray();

        Console.WriteLine(obj.MinPatches(new int[]{1,3},6));
        Console.WriteLine(obj.MinPatches(new int[]{1,5,10},20));
        Console.WriteLine(obj.MinPatches(new int[]{1,2,2},5));
    }
}