/*
Write a program to create a calculator using switch...case.
Hint => 
Create two double variables named first and second and a String variable named op.
Get input values for all variables.
The input for the operator can only be one of the four values: "+", "-", "*" or "/".
Run a for loop from i = 1 to i < number.
Based on the input value of the op, perform specific operations using the switch...case statement and print the result.
If op is +, perform addition between first and second; if it is -, perform subtraction and so on.
If op is neither of those 4 values, print Invalid Operator.
*/

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Number, Not 0 if you want to divide");
        double second = Convert.ToDouble(Console.ReadLine());
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine(first + second);
                break;
            case "-":
                Console.WriteLine(first - second);
                break;
            case "*":
                Console.WriteLine(first * second);
                break;
            case "/":
                Console.WriteLine(first / second);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }

    }
}