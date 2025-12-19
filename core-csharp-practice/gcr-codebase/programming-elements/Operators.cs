
class Operators
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nArithmetic operators are used to perform mathematical operations.");
        Arithmetic();
        Console.WriteLine("\nRelational operators are used to compare two values.");
        Relational();
        Console.WriteLine("\nLogical operators are used to compare two values.");
        Logical();
        Console.WriteLine("\nAssignment operators are used to assign values to variables.");
        Assignment();
        Console.WriteLine("\nUnary operators are used to operate on single operand.");
        Unary();
        Console.WriteLine("\nTernary operators are used to operate on three operands.");
        Ternary();
        Console.WriteLine("\nis operator checks whether the variable is of given type or not.");
        Is();
    }

    static void Arithmetic()
    {
        int a = 10;
        int b = 5;
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b)); // b should not be zero
        Console.WriteLine("Modulus: " + (a % b));

    }
    static void Relational()
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("Equal to " + (a == b));
        Console.WriteLine("Not equal to " + (a != b));
        Console.WriteLine("Greater than " + (a > b));
        Console.WriteLine("Lesser than " + (a < b));
        Console.WriteLine("Greater or Equal to " + (a >= b));
        Console.WriteLine("Lesser or Equal to " + (a <= b));
    }
    static void Logical()
    {
        bool a = true;
        bool b = false;
        Console.WriteLine("Logical AND " + (a && b));
        Console.WriteLine("Logical OR " + (a || b));
        Console.WriteLine("Logical NOT " + (!a));
    }

    static void Assignment()
    {
        Console.WriteLine("Assignment Operator = is used to assign right side value to left side like a = 10"); ;
        int a = 10;
        int b = 20;
        Console.WriteLine("Addition Assignment Operator (a += b): a is 10 and b is 20 then in the end a becomes" + (a += b));
        Console.WriteLine("Subtraction Assignment Operator (a -= b): a is 10 and b is 20 then in the end a becomes" + (a -= b));
        Console.WriteLine("Multiplication Assignment Operator (a *= b): a is 10 and b is 20 then in the end a becomes" + (a *= b));
        Console.WriteLine("Division Assignment Operator (a /= b): a is 10 and b is 20 then in the end a becomes" + (a /= b));
        Console.WriteLine("Modulus Assignment Operator (a %= b): a is 10 and b is 20 then in the end a becomes" + (a %= b));
    }
    static void Unary()
    {
        int a = 10;
        Console.WriteLine("a: " + a);
        Console.WriteLine("PreIncrement operator ++a: " + ++a);
        Console.WriteLine("PostIncrement operator a++: " + a++);
        Console.WriteLine("a: " + a);
        Console.WriteLine("PreDecrement operator --a: " + --a);
        Console.WriteLine("PostDecrement operator a--: " + a--);
        Console.WriteLine("a: " + a);
    }
    static void Ternary()
    {
        int a = 10, b = 20;
        string result = (a > b) ? "a is greater than b" : "b is greater than a";
        Console.WriteLine(result);
    }
    static void Is()
    {
        Console.WriteLine(" is operator checks whether the variable is of given type or not");
        int a = 10;
        if (a is int)
            Console.WriteLine("a is an integer");
        else
            Console.WriteLine("a is not an integer");
    }
}