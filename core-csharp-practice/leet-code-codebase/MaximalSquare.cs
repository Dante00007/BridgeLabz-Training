class MaximalSquare {

    public static int FindMaximalSquare(char [,] matrix) {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        int [,] dp = new int[m,n];
        int maxSize = 0;
        
        for (int i = 0; i < m; ++i) {
            for (int j = 0; j < n; ++j) {
                if (matrix[i,j] == '1') {
                    if (i == 0 || j == 0) {
                        dp[i,j] = 1;
                    } else {
                        dp[i,j] = Math.Min(dp[i-1,j],Math.Min(dp[i,j-1], dp[i-1,j-1])) + 1;
                    }
                    maxSize = Math.Max(maxSize, dp[i,j]);
                }
            }
        }

        return maxSize * maxSize;
    }
    static void Main(){
        char [,] matrix = new char[4,5]{{'1','0','1','0','0'},
                                        {'1','0','1','1','1'},
                                        {'1','1','1','1','1'},
                                        {'1','0','0','1','0'}};
        Console.WriteLine(FindMaximalSquare(matrix)); //4
    }
};