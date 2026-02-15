using System.Reflection;
using System.Threading;
class ExecutionTimer
{
    public static void MeasureTime(object target, string methodName)
    {
        MethodInfo method = target.GetType().GetMethod(methodName);
        var watch = System.Diagnostics.Stopwatch.StartNew();
        method.Invoke(target, null);
        watch.Stop();
        Console.WriteLine($"{methodName} took {watch.ElapsedMilliseconds}ms");
    }

    public void HeavyTask() => Thread.Sleep(100);

    static void Main(string[] args)
    {
        ExecutionTimer timer = new ExecutionTimer();
        MeasureTime(timer, "HeavyTask");
    }
}