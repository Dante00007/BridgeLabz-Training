
class BMI
{
    public static string[] FindStatus(double[] bmi)
    {
        string[] status = new string[bmi.Length];
        for (int i = 0; i < bmi.Length; i++)
        {
            if (bmi[i] < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
            {
                status[i] = "Normal";
            }
            else if (bmi[i] >= 25 && bmi[i] <= 29.9)
            {
                status[i] = "OverWeight";
            }
            else
            {
                status[i] = "Obese";
            }
        }
        return status;
    }
    public static double[] FindBMI(double[,] arr)
    {
        double[] bmi = new double[arr.GetLength(0)];
        for (int i = 0; i < bmi.Length; i++)
        {
            bmi[i] = arr[i, 0] / Math.Pow(arr[i, 1], 2);
        }
        return bmi;
    }
    static void Main()
    {
        double[,] arr = new double[10, 3];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("Enter Weight in kg");
            arr[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height in cm");
            arr[i, 1] = Convert.ToDouble(Console.ReadLine()) / 100;
        }
        double[] bmi = FindBMI(arr);
        double[] status = FindStatus(bmi);

        for (int i = 0; i < bmi.Length; i++)
        {
            Console.WriteLine("Person{0}: Weight={1}kg, Height={2}cm,BMI={3},Status={4}", i + 1,
            arr[i, 0], arr[i, 1], bmi[i], status[i]);
        }

    }
}