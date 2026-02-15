
using System;
using System.Reflection;
class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class ReflectionMath
{
    static void Main(string[] args)
    {
        MathOperations math = new MathOperations();
        Type type = typeof(MathOperations);
        MethodInfo method = type.GetMethod(Console.ReadLine(), BindingFlags.Instance | BindingFlags.Public);
        int result = (int)method.Invoke(math, new object[] { int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) });
        Console.WriteLine("Result: " + result);
    }
}