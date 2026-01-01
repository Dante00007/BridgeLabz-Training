
class Circle{
    private int radius;

    public Circle(int r){
        this.radius = r;
    }
    public double GetArea(){
        return Math.PI * (this.radius*this.radius);
    }
    public double GetCircumference(){
        return 2*Math.PI*this.radius;
    }

    public static void Main()
    {
        Console.WriteLine("Enter the Radius of circle");
        int r = Convert.ToInt32(Console.ReadLine());
        Circle c1 = new Circle(r);
        Console.WriteLine("Area of circle is "+c1.GetArea());
        Console.WriteLine("Circumference of circle is "+c1.GetCircumference());
    }
}