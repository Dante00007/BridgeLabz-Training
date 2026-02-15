using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}
class JsonGenerator
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        List<string> pairs = new List<string>();
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            object value = field.GetValue(obj);
            string valStr = value is string ? $"\"{value}\"" : value.ToString();
            pairs.Add($"\"{field.Name}\": {valStr}");
        }
        return "{" + string.Join(", ", pairs) + "}";
    }

    static void Main(string[] args)
    {
        User user = new User { Name = "Bob", Age = 30 };
        Console.WriteLine(ToJson(user));
    }
}