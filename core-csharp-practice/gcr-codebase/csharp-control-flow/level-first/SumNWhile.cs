/*
Write a program to find the sum of n natural numbers using while loop compare the result with the formulae n*(n+1)/2 and show the result from both computations was correct. 
Hint => 
Take the user input number and check whether it's a Natural number
If it's a natural number Compute using formulae as well as compute using while loop
Compare the two results and print the result
*/

class SumNWhile
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Enter Number");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            int i = 1;
            while (i <= num)
            {
                sum += i;
                i++;
            }
            int sumFormulae = num * (num + 1) / 2;
            if (sum == sumFormulae)
            {
                Console.WriteLine("Both the computation are same {0}. Using While Loop :{0}, Using Formulae:{1}", sum, sumFormulae);
            }
            else
            {
                Console.WriteLine("Both the computation are different. Using While Loop :{0}, Using Formulae:{1}", sum, sumFormulae);
            }
        }
        else
        {
            Console.WriteLine("The number {0} is not a natural number", num);
        }
    }
}