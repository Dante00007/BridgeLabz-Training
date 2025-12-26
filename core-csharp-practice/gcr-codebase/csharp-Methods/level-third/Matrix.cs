using System;

class Matrix
{
    public static double[,] AddMatrix(double[,] arr1, double[,] arr2) {
        if(arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1)) {
            return null;
        }

        double[,] res = new double[arr1.GetLength(0), arr1.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++) {
            for (int j = 0; j < arr1.GetLength(1); j++) {
                res[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return res;
    }

    public static double[,] SubtractMatrix(double[,] arr1, double[,] arr2) {
        if(arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1)) {
            return null;
        }

        double[,] res = new double[arr1.GetLength(0), arr1.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++) {
            for (int j = 0; j < arr1.GetLength(1); j++) {
                res[i, j] = arr1[i, j] - arr2[i, j];
            }
        }
        return res;
    }

    public static double[,] MultiplyMatrix(double[,] arr1, double[,] arr2) {
        if(arr1.GetLength(1) != arr2.GetLength(0)) {
            return null;
        }

        double[,] res = new double[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++) {
            for (int j = 0; j < arr2.GetLength(1); j++) {
                for (int k = 0; k < arr1.GetLength(1); k++) {
                    res[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        return res;
    }

    public static double[,] TransposeMatrix(double[,] arr) {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        double[,] transposed = new double[cols, rows];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                transposed[j, i] = arr[i, j];
            }
        }
        return transposed;
    }

    public static double Determinant2x2(double[,] arr) {
        return arr[0, 0] * arr[1, 1] - arr[0, 1] * arr[1, 0];
    }

    public static double Determinant3x3(double[,] arr) {
        double ith = arr[0, 0] * (arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1]);
        double jth = arr[0, 1] * (arr[1, 0] * arr[2, 2] - arr[1, 2] * arr[2, 0]); // Fixed sign logic
        double kth = arr[0, 2] * (arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0]);
        return ith - jth + kth;
    }

    public static double[,] Inverse2X2(double[,] arr) {
        double det = Determinant2x2(arr);
        if (det == 0) return null;

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = arr[1, 1] / det;
        inverse[0, 1] = -arr[0, 1] / det;
        inverse[1, 0] = -arr[1, 0] / det;
        inverse[1, 1] = arr[0, 0] / det;
        return inverse;
    }

    public static double[,] Inverse3X3(double[,] arr) {
        double det = Determinant3x3(arr);
        if (det == 0) return null;

        double invDet = 1.0 / det;
        double[,] res = new double[3, 3];

        res[0, 0] = (arr[1, 1] * arr[2, 2] - arr[1, 2] * arr[2, 1]) * invDet;
        res[0, 1] = (arr[0, 2] * arr[2, 1] - arr[0, 1] * arr[2, 2]) * invDet;
        res[0, 2] = (arr[0, 1] * arr[1, 2] - arr[0, 2] * arr[1, 1]) * invDet;

        res[1, 0] = (arr[1, 2] * arr[2, 0] - arr[1, 0] * arr[2, 2]) * invDet;
        res[1, 1] = (arr[0, 0] * arr[2, 2] - arr[0, 2] * arr[2, 0]) * invDet;
        res[1, 2] = (arr[1, 0] * arr[0, 2] - arr[0, 0] * arr[1, 2]) * invDet;

        res[2, 0] = (arr[1, 0] * arr[2, 1] - arr[1, 1] * arr[2, 0]) * invDet;
        res[2, 1] = (arr[2, 0] * arr[0, 1] - arr[0, 0] * arr[2, 1]) * invDet;
        res[2, 2] = (arr[0, 0] * arr[1, 1] - arr[1, 0] * arr[0, 1]) * invDet;

        return res;
    }

    public static double[,] CreateRandomMatrix(int row, int col) {
        Random rand = new Random();
        double[,] matrix = new double[row, col];
        for (int i = 0; i < row; i++) {
            for (int j = 0; j < col; j++) {
                matrix[i, j] = rand.Next(1, 11); 
            }
        }
        return matrix;
    }

    public static void DisplayMatrix(double[,] matrix) {
        if (matrix == null) {
            Console.WriteLine("Matrix is null (Check dimensions/determinant)");
            return;
        }
        for (int i = 0; i < matrix.GetLength(0); i++) {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write($"{matrix[i, j], 8:F2}"); 
            }
            Console.WriteLine();
        }
    }

    static void Main() {
        Console.Write("Enter the number of Rows: ");
        int rows = Convert.ToInt32(Console.ReadLine()); // Fixed ReaLine typo
        Console.Write("Enter the number of Cols: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        double[,] arr1 = CreateRandomMatrix(rows, cols);
        double[,] arr2 = CreateRandomMatrix(rows, cols);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(arr1);

        Console.WriteLine("Matrix 2:");
        DisplayMatrix(arr2);

        Console.WriteLine("Addition Result:");
        DisplayMatrix(AddMatrix(arr1, arr2));

        Console.WriteLine("Subtraction Result:");
        DisplayMatrix(SubtractMatrix(arr1, arr2));

        if (rows == 2 && cols == 2) {
            Console.WriteLine("Inverse (2x2):");
            DisplayMatrix(Inverse2X2(arr1));
        }
        else if (rows == 3 && cols == 3) {
            Console.WriteLine("\nInverse (3x3):");
            DisplayMatrix(Inverse3X3(arr1));
        }
    }
}