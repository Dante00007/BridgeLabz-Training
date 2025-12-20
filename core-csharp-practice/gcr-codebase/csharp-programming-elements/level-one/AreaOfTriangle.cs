class AreaOfTriangle
{
    public static void Main()
    {
        Console.WriteLine("Enter base and height");
        int basee = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());
        double areaInSquareInches = 0.5 * base * height;
        double areaInSquareCentimeters = areaInSquareInches * 6.4516;
        Console.WriteLine("The area of the triangle in square inches is " + areaInSquareInches + " and in square centimeters is " + areaInSquareCentimeters);
    }
}