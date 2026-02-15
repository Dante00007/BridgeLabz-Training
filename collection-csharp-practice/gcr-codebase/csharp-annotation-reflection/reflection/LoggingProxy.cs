using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class LoggingProxy
{
    public static void InvokeWithLog(object target, string methodName, params object[] args)
    {
        Type type = target.GetType();
        MethodInfo method = type.GetMethod(methodName);
        Console.WriteLine($"[LOG] Executing: {methodName}");
        method.Invoke(target, args);
    }

    static void Main(string[] args)
    {
        User user = new User();
        InvokeWithLog(user, "ToString");
    }
}