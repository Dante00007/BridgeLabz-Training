class AllocatingBooks {
    public bool IsPossible(int[] arr, int k, int mid){
        int cnt = 1;
        int sum = 0;
        for(int i=0;i<arr.Length;i++){
            if(sum + arr[i] > mid){
                cnt++;
                sum = arr[i];
            }else{
                sum += arr[i];
            }
        }
        return cnt <= k;
    }
    public int MinPages(int[] arr, int k)
    {
        int n = arr.Length;
        if (n < k) return -1;

        int low  = arr.Max();
        int high = arr.Sum();
        int res = -1;

        int mid = low + ((high-low)/2);
        while(low <= high){
            
            if(IsPossible(arr,k,mid)){
                res = mid;
                high = mid-1;
            }else{
                low = mid+1;
            }
            mid = low + ((high-low)/2);
        }

        return res;
    }

    static void Main(string[] args)
    {
        int[] arr = {12, 34, 67, 90};
        int k = 2;
        Console.WriteLine(new AllocatingBooks().MinPages(arr,k));
    }
}