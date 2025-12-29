
class AggressiveCows
{
    static bool IsPossible(int[] stalls,int dist,int k)
    {
        int cowCount=1; 
        int lastPos=stalls[0]; 
        for(int i=1;i<stalls.Length;i++)
        {
            if(stalls[i]-lastPos>=dist)
            {
                cowCount++;
                lastPos=stalls[i];
            }
            if(cowCount>=k)
                return true;
        }
        return false;
    }
    static int Solve(int[] stalls,int k)
    {
        int n = stalls.Length;
        int ans=-1;

        int minDist=0;
        int maxDist=stalls[n-1]-stalls[0];
        
        int mid=minDist+(maxDist-minDist)/2;
        while(minDist<=maxDist)
        {
            
            if(IsPossible(stalls,mid,k))
            {
                ans=mid;
                minDist=mid+1;
            }
            else
                maxDist=mid-1;
        }
        return ans;
    }
    static void Main()
    {
        int []stalls =[1, 2, 4, 8, 9];
        int k = 3;
        Console.WriteLine(Solve(stalls,k));//3
    }
}