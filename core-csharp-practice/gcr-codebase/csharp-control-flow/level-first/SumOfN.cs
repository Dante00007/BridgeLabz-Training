/*
Write a program to check for the natural number and write the sum of n natural numbers 
Hint => 
A Natural Number is a positive integer (1,2,3, etc) sometimes with the inclusion of 0
A sum of n natural numbers is n * (n+1) / 2 
I/P => number
O/P => If the number is a positive integer then the output is
The sum of ___ natural numbers is ___
Otherwise 
The number ___ is not a natural number
*/

class SumOfN
{
    static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
            Console.WriteLine("The sum of " + num + " natural numbers is " + (num * (num + 1) / 2));
        else
            Console.WriteLine("The number " + num + " is not a natural number");
    }
}