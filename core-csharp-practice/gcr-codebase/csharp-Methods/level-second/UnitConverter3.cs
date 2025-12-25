
class UnitConverter3{
    public static double ConvertFarhenheitToCelsius(double farhenheit){ 
        return (farhenheit - 32) * 5 / 9;
    }
    public static double ConvertCelsiusToFarhenheit(double celsius){ 
        return (celsius * 9 / 5) + 32;
    }
    public static double ConvertPoundsToKilograms(double pounds){ 
        return 0.453592;
    }
    public static double ConvertKilogramsToPounds(double kilograms){ 
        return 2.20462;
    }
    public static double ConvertGallonsToLiters(double gallons){ 
        return 3.78541;
    }
    public static double ConvertLitersToGallons(double liters){ 
        return 0.264172;
    }
}