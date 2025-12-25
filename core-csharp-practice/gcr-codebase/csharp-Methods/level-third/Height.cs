
class Height{
    static int FindSum(int[] heights){
        int sum = 0;
        for(int i=0;i<heights.Length;i++){
            sum += heights[i];
        }
        return sum;
    }
    static int FindMean(int[] heights,int sum){
        return sum/heights.Length;
    }
    static int FindShortest(int[] heights){
        int shortest = heights[0];
        for(int i=0;i<heights.Length;i++){
            if(heights[i]<shortest){
                shortest = heights[i];
            }
        }
        return shortest;
    }
    static int FindTallest(int[] heights){
        int tallest = heights[0];
        for(int i=0;i<heights.Length;i++){
            if(heights[i]>tallest){
                tallest = heights[i];
            }
        }
        return tallest;
    }
    static void Main(){
        int [] heights = new int[11];
        for(int i=0;i<heights.Length;i++){
            Console.Write("Enter Height in cm ");
            heights[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = FindSum(heights);
        int mean = FindMean(heights,sum);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("The Sum is {0}, The Mean is {1}, The Shortest is {2}, The Tallest is {3}",sum,mean,shortest,tallest);
    }
}