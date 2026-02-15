

using System;
using System.Reflection;
class Configuration
{
    private static string _apiKey = "1234567890";
    public static string ApiKey
    {
        get { return _apiKey; }
        set { _apiKey = value; }
    }
}

class ReflectionStatic
{
    static void Main(string[] args)
    {
        Type type = typeof(Configuration);
        FieldInfo field = type.GetField("_apiKey", BindingFlags.NonPublic | BindingFlags.Static);
        field.SetValue(null, "9876543210");
        Console.WriteLine("API Key: " + Configuration.ApiKey);
    }
}