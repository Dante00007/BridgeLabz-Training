using System;
using System.Reflection;
class Student
{
    public string name;
    public int age;

    public Student(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class ReflectionStudent
{
    static void Main(string[] args)
    {
        Type type = typeof(Student);
        ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string), typeof(int) });
        
        Student student = (Student)constructor.Invoke(new object[] { "John", 20 });

        Console.WriteLine("Name: " + student.name);
        Console.WriteLine("Age: " + student.age);


    }
}