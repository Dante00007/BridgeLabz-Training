class Volume{
    public static void Main(){
        double vol = (4/3)*Math.PI*Math.Pow(6378,3);
        Console.WriteLine("The volume of earth in cubic kilometers is "+vol+" and cubic miles is "+((float)vol*0.5));
    }
}