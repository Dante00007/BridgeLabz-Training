
class Pens{
    public static void Main(string[] args)
    {
        int totalPens = 14;
        int totalStudents = 3;
        int pensPerStudent = totalPens / totalStudents;
        int remainingPens = totalPens % totalStudents;
        Console.WriteLine("The Pen Per Student is {0} and the remaining pen not distributed is {1}",pensPerStudent,remainingPens);
    }
}