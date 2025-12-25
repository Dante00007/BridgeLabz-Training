

class UnitConverter2{
    public static double ConvertYardsToFeet(double yards){ 
        return yards * 3;
    }
    public static double ConvertFeetToYards(double feet){ 
        return feet / 3;
    }
    public static double ConvertMetersToInches(double meters){
        return meters * 39.3701;
    }
    public static double ConvertInchesToMeters(double inches){ 
        return inches / 39.3701;
    }   
    public static double ConvertInchesToCentimeters(double inches) {
        return inches * 2.54;
    }
}