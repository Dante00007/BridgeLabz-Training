
using System.Reflection;

class FieldPerson
{
    private string Name;
    private int Age;

    public FieldPerson(string name, int age)
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
       
        Type personType = Type.GetType("FieldPerson");

        object person = Activator.CreateInstance(personType, "John", 25);


        FieldInfo[] fieldInfos = personType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine("Old Values:");
        foreach (FieldInfo field in fieldInfos)
        {
            Console.WriteLine(field.Name+" "+field.GetValue(person));
        }

        fieldInfos[0].SetValue(person, "Jane");
        fieldInfos[1].SetValue(person, 30);

        Console.WriteLine("\nNew Values:");
        foreach (FieldInfo field in fieldInfos)
        {
            Console.WriteLine(field.Name+" "+field.GetValue(person));
        }

        
       

    }
}