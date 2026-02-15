
using System.Reflection;

class Person
{
    private string Name;
    private int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greetings()
    {
        Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
    } 
}

class PersonInfo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Class name: ");
        string name = Console.ReadLine();
        Type personType = Type.GetType(name);

        object person = Activator.CreateInstance(personType, "John", 25);

        MethodInfo[] methodInfos = personType.GetMethods();
        Console.WriteLine("Methods:");
        foreach (MethodInfo methodInfo in methodInfos)
        {
            Console.WriteLine(methodInfo.Name);
        }

        FieldInfo[] fieldInfos = personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine("Fields:");
        foreach (FieldInfo fieldInfo in fieldInfos)
        {
            Console.WriteLine(fieldInfo.Name);
        }

        
        ConstructorInfo[] constructorInfos = personType.GetConstructors();
        Console.WriteLine("Constructor:");
        foreach (ConstructorInfo constructorInfo in constructorInfos)
        {
            Console.WriteLine(constructorInfo.Name);
        }

    }
}