
class UnitConverter
{
    
    public static double ConvertKmToMiles(double km)
    {
        double kmToMilesFactor = 0.621371;
        return km * kmToMilesFactor;
    }

    public static double ConvertMilesToKm(double celsius)
    {
        double milesToKmFactor = 1 / 0.621371;
        return celsius * milesToKmFactor;
    }

    public static void ConvertMetersToFeet(double meters)
    {
        double meterstoFeetFactor = 3.28084;
        Console.WriteLine(meters + " meters is equal to " + (meters * meterstoFeetFactor));
    }
    
    public static void ConvertFeetToMeter(double feet)
    {
        double feettometerFactor = 1 / 3.28084;
        Console.WriteLine(feet + " feet is equal to " + (feet * feettometerFactor));
    }

}
