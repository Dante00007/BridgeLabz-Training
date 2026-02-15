

using System.Reflection;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("John Doe")]
class AuthorClass
{

}
class ReflectionAttribute
{
    static void Main(string[] args)
    {
        Type type = typeof(AuthorClass);
        AuthorAttribute attribute = type.GetCustomAttribute<AuthorAttribute>();
        Console.WriteLine(attribute.Name);
    }
}