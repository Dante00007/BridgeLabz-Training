class SumOfN
{
    static int SumOfNaturalNumbers(int n)
    {
        if(n == 0)
            return 0;

        return n + SumOfNaturalNumbers(n - 1);
    }
    static void Main()
    {
        Console.WriteLine("Enter the Number ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sumFormula = num * (num + 1) / 2;
        int sumRecursion = SumOfNaturalNumbers(num);

        if (sumFormula == sumRecursion)
            Console.WriteLine("Both the computation are same {0}. Using Recursion :{0}, Using Formulae:{1}", sumRecursion, sumFormula);
        else
            Console.WriteLine("Both the computation are different. Using Recursion :{0}, Using Formulae:{1}", sumRecursion, sumFormula);
    }
}