
using System;
using System.Reflection;


[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service { public void Run() => Console.WriteLine("Service Running"); }

class Client
{
    [Inject] public Service MyService;
}

class SimpleDI
{
    public static void Initialize(object obj)
    {
        Type type = obj.GetType();
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            if (field.GetCustomAttribute<InjectAttribute>() != null)
            {
                field.SetValue(obj, Activator.CreateInstance(field.FieldType));
            }
        }
    }

    static void Main(string[] args)
    {
        Client client = new Client();
        Initialize(client);
        client.MyService.Run();
    }
}