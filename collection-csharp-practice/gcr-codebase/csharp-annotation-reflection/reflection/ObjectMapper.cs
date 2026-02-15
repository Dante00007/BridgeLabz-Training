using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);
        foreach (var entry in properties)
        {
            FieldInfo field = type.GetField(entry.Key, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
            if (field != null)
            {
                field.SetValue(obj, entry.Value);
            }
        }
        return obj;
    }

    static void Main(string[] args)
    {
        var data = new Dictionary<string, object> { { "Name", "Alice" }, { "Age", 25 } };
        User user = ToObject<User>(data);
        Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
    }
}