
class MaximalRectangle
{

    static int largestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        for (int i = 0; i < heights.Length;){
            while (stack.Count > 0 &&  heights[stack.Peek()] >= heights[i]){
                int height = heights[stack.Pop()];
                int width = stack.Count > 0 ? i - stack.Peek() - 1 : i;
                maxArea = Math.Max(maxArea, height * width);
            }
            stack.Push(i);
        }
        while(stack.Count > 0)
        {
            int height = heights[stack.Pop()];
            int width = stack.Count > 0 ? heights.Length - stack.Peek() - 1 : heights.Length;
            maxArea = Math.Max(maxArea, height * width);
        }
        return maxArea;
    }

static int MaxArea(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int[] heights = new int[n];
    int max = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] == 1)
            {
                heights[j] += 1;
            }
            else
            {
                heights[j] = 0;
            }
        }
        int area = largestRectangleArea(heights);
        max = Math.Max(area, max);
    }
    return max;
}


static void Main()
{
    int[,] mat = {
            {0,1,1,0},
            {1,1,1,1},
            {1,1,1,1},
            {1,1,0,0}
        };

    Console.WriteLine(MaxArea(mat));
}
            
}