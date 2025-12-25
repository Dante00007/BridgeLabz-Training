

class EuclideanDistance{
    public static double CalculateDistance(double x1, double y1, double x2, double y2) {
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return distance;
    }
    public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2) {
        double slope = (y2 - y1) / (x2 - x1);
        double yIntercept = y1 - slope * x1;
        return new double[] { slope, yIntercept };
    }
    static void Main() {
        Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2);
        Console.WriteLine("The Euclidean distance between the two points is: {0}", distance);

        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        Console.WriteLine("The equation of the line is: y = {0}x + {1}", lineEquation[0], lineEquation[1]);
    }
}