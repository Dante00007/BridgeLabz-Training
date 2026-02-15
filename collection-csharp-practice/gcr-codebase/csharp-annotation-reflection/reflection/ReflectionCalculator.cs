using System;
using System.Reflection;
class Calculator
{
    private int a;
    private int b;

    public Calculator(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    private int Add()
    {
        return a + b;
    }

    private int Subtract()
    {
        return a - b;
    }

    private int Multiply()
    {
        return a * b;
    }

    private int Divide()
    {
        return a / b;
    }
}

class ReflectionCalculator
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(10, 5);
        Type type = typeof(Calculator);
        MethodInfo method = type.GetMethod("Multiply", BindingFlags.Instance | BindingFlags.NonPublic);
        int result = (int)method.Invoke(calculator, null);
        Console.WriteLine("Multiplication: " + result);
    }
}